using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using RainstormStudios.Controls;
using RainstormStudios.Unmanaged;

namespace RegexTester
{
    class ctrlRegExTextBox : RainstormStudios.Controls.AdvRichTextBox
    {
        #region Declarations
        //***************************************************************************
        // Constants
        // 
        const int
            leftMargin = 45;
        static readonly Color
            leftMarginBgColor = Color.Silver,
            lineNumberColor = Color.DarkBlue;
        //***************************************************************************
        // Private Fields
        // 
        private static readonly object
            lockMe = new object();
        private Regex
            _rgxGroup,
            _rgxBackRef,
            _rgxCode,
            _rgxLenQuant,
            _rgxComment;
        private Color
            _clrBackRef,
            _clrCode,
            _clrGroup,
            _clrGroupNm,
            _clrGroupMatch,
            _clrLenQuant,
            _clrComment;
        private bool
            _parsing = false,
            _init = false,
            _canEdit,
            _insMode,
            _txtChngHandled;
        private int
            _selStart = 0,
            _selLength = 0,
            _lastParseLine,
            _lastPrintLine,
            _addToSel = 0;
        private List<Int32>
            _bldChars;
        private System.Windows.Forms.Keys
            _lastKeyPress;
        //***************************************************************************
        // Delegate Definitions
        // 
        private delegate void DoParseDelegate(int start, int length);
        private delegate string ParseTextDelegate(string value);
        private delegate void UpdateTextDelegate(string rtfValue);
        private delegate void SetCaretPositionDelegate(int StartPos, int SelLength);
        //***************************************************************************
        // Public Events
        // 
        public event EventHandler TextParsed;
        public event EventHandler InsertModeChanged;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public bool IsInsertMode
        {
            get { return this._insMode; }
            set
            {
                if (this._insMode != value)
                {
                    this._insMode = value;
                    this.OnInsertModeChanged(EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public ctrlRegExTextBox()
            : base()
        {
            try
            {
                this.InitRegEx();
                this.InitColors();
                this._bldChars = new List<int>(5);
            }
            catch
            {
                this._parsing = true;
            }
            this._insMode = true;
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void BeginParse()
        {
            this._parsing = true;
            this._canEdit = !this.ReadOnly;
            this.ReadOnly = true;
            DoParseDelegate del = new DoParseDelegate(this.DoParse);
            del.BeginInvoke(0, this.Text.Length, new AsyncCallback(this.DoParseCallback), del);
        }
        public void SuspendParse()
        {
            this._parsing = true;
        }
        public void RemoveParse()
        {
            this.ResumeParse(false);
        }
        public void ResumeParse(bool parseNow)
        {
            this._parsing = false;
            if (parseNow)
                this.DoParse(0, this.Text.Length);
        }
        #endregion

        #region Non-Public Methods
        //***************************************************************************
        // Initialization
        // 
        private void InitRegEx()
        {
            RegexOptions rgxOpts = RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
            this._rgxGroup = new Regex(@"(?<!\\)(?:\(\?<(?<groupName>.*?)>)(?<matchString>.*?)(?:\){1})", rgxOpts);
            this._rgxLenQuant = new Regex(@"(?<!\\|\()(\?|[\*\+]\??)", rgxOpts);
            this._rgxBackRef = new Regex(@"\(\?\<?[!=].*?\)", rgxOpts);
            this._rgxCode = new Regex(@"(?<!\\)((?<!\(\?\#)\.(?!\))|\\(?:[wWsSQeEanrtfvb]{1}|[0-9]{3}|c[A-Z]{1}|u[0-9]{4}))", rgxOpts);
            this._rgxComment = new Regex(@"(?<!\\)\(\?\#.*?\)", rgxOpts);
        }
        private void InitColors()
        {
            this._clrBackRef = System.Drawing.Color.Goldenrod;
            this._clrCode = System.Drawing.Color.Blue;
            this._clrGroup = System.Drawing.Color.FromArgb(90, 0, 0);
            this._clrGroupNm = System.Drawing.Color.FromArgb(160, 90, 90);
            this._clrGroupMatch = System.Drawing.Color.FromArgb(170, 0, 0);
            this._clrLenQuant = System.Drawing.Color.FromArgb(128, 90, 128);
            this._clrComment = System.Drawing.Color.DarkGreen;
        }
        //***************************************************************************
        // Private Methods
        // 
        private void SetColored(int start, int length, Color clr)
        {
            // Select the found element and set its for color.
            if (this._selDir == RainstormStudios.Controls.AdvRichTextBox.SelectDirection.Backword)
                this.Select(start + length, -length);
            else
                this.Select(start, length);
            this.SelectionColor = clr;
        }
        private void Parse()
        {
            this.DoParse(0, this.Text.Length);
        }
        private void ParseCurrentLine()
        {
            // Prevent the control from scroll or redrawing itself.
            this._parsing = true;
            base.SuspendRefresh();
            base.SuspendScroll();
            this.SuspendLayout();

            // Save the current carrat and scroll bar positions.
            int selStart = this.SelectionStart,
                selLength = this.SelectionLength;
            int hScrPos = this.HorizontalScrollPos,
                vScrPos = this.VerticalScrollPos;

            try
            {
                int iCurLine = this.GetFirstCharIndexOfCurrentLine();
                int iEoLine = this.Lines[this.GetLineFromCharIndex(iCurLine)].Length;
                this.DoParse(iCurLine, iEoLine);
            }
            finally
            {
                // Set the carat to the end of whatever we just highlighted and set the
                //   color back to the control's ForeColor.  This keeps us from
                //   continuing to type in the color of whatever we just entered.
                if (this._selDir == RainstormStudios.Controls.AdvRichTextBox.SelectDirection.Backword)
                    this.Select(selStart + selLength, -selLength);
                else
                    this.Select(selStart, selLength);
                this.SelectionColor = this.ForeColor;
                this._parsing = false;

                // Allow the control to resume drawing and scrolling.
                this.VerticalScrollPos = vScrPos;
                this.HorizontalScrollPos = hScrPos;
                this.ResumeLayout(true);
                base.ResumeScroll();
                base.ResumeRefresh();
                this.OnTextParsed(EventArgs.Empty);
            }
        }
        private void DrawMargin(Graphics g, Rectangle clip)
        {
            using (SolidBrush brush = new SolidBrush(leftMarginBgColor))
                g.FillRectangle(brush, 0, 0, leftMargin - 5, this.ClientSize.Height);
            g.DrawLine(Pens.Black, new Point(leftMargin - 5, 0), new Point(leftMargin - 5, this.ClientSize.Height));

            using (SolidBrush txtBrush = new SolidBrush(lineNumberColor))
            using (StringFormat format = new StringFormat(StringFormatFlags.NoWrap | StringFormatFlags.FitBlackBox))
            {
                int topLineNum = this.GetLineFromCharIndex(this.GetCharIndexFromPosition(new Point(2, 2)));
                format.LineAlignment = StringAlignment.Far;
                format.Alignment = StringAlignment.Far;
                for (int i = 0; i < this.ClientRectangle.Height; i++)
                    g.DrawString(
                        Convert.ToString(i + topLineNum + 1),
                        this.Font,
                        txtBrush,
                        new RectangleF(
                                new PointF(2.0f, (float)(i * (this.Font.Height + 1) + 2)),
                                new SizeF(
                                        (float)(leftMargin - 5),
                                        (float)this.Font.Height)),
                        format);
            }
        }
        //***************************************************************************
        // Thread Processors
        // 
        private void DoParse(int start, int length)
        {
            // If we got passed a bad length, just abort rather then throw
            //   an exception.
            if (start < 0 || length < 1 || (start + length) > this.Text.Length)
                return;

            int selStart = this.SelectionStart,
                selLength = this.SelectionLength;

            try
            {
                this._parsing = true;
                string strCurLine = this.Text.Substring(start, length);

                this.Select(start, length);
                this.SelectionColor = this.ForeColor;

                Match m;
                for (m = this._rgxGroup.Match(strCurLine); m.Success; m = m.NextMatch())
                {
                    this.SetColored(m.Index + start, m.Length, this._clrGroup);
                    this.SetColored(m.Groups[0].Index + start, m.Groups[0].Length, this._clrGroupMatch);
                    this.SetColored(m.Groups[1].Index + start, m.Groups[1].Length, this._clrGroupNm);
                }

                for (m = this._rgxBackRef.Match(strCurLine); m.Success; m = m.NextMatch())
                    this.SetColored(m.Index + start, m.Length, this._clrBackRef);

                for (m = this._rgxCode.Match(strCurLine); m.Success; m = m.NextMatch())
                    this.SetColored(m.Index + start, m.Length, this._clrCode);

                for (m = this._rgxLenQuant.Match(strCurLine); m.Success; m = m.NextMatch())
                    this.SetColored(m.Index + start, m.Length, this._clrLenQuant);

                for (m = this._rgxComment.Match(strCurLine); m.Success; m = m.NextMatch())
                    this.SetColored(m.Index + start, m.Length, this._clrComment);
            }
            catch (Exception ex)
            {
                this.Text = ex.ToString();
            }
            finally
            {
                if (this._selDir == RainstormStudios.Controls.AdvRichTextBox.SelectDirection.Backword)
                    this.Select(selStart + selLength, -selLength);
                else
                    this.Select(selStart, selLength);
                this._parsing = false;
            }
        }
        private void DoParseCallback(IAsyncResult state)
        {
            DoParseDelegate del = (DoParseDelegate)state.AsyncState;
            del.EndInvoke(state);
            RainstormStudios.CrossThreadUI.SetPropertyValue(this, "ReadOnly", !this._canEdit);
            this._parsing = false;
            this.OnTextParsed(EventArgs.Empty);
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Overrides
        // 
        protected override void OnTextChanged(EventArgs e)
        {
            if (!_parsing && !this._txtChngHandled)
            {
                base.OnTextChanged(e);
                if (this.Text.Length > 0)
                    this.ParseCurrentLine();
            }
            this._txtChngHandled = false;
        }
        protected override void OnPaste(EventArgs e)
        {
            this._parsing = true;
            try
            {
                int
                    iLnCnt = this.Lines.Length,
                    iStrtLn = this.GetLineFromCharIndex(this.SelectionStart);

                base.OnPaste(e);
                if (this.Lines.Length > iLnCnt)
                {
                    int startChr = this.GetFirstCharIndexFromLine(iStrtLn),
                        endLn = this.GetFirstCharIndexFromLine(((this.Lines.Length - 1) - iLnCnt) + iStrtLn),
                        endChr = endLn + this.Lines[this.GetLineFromCharIndex(endLn)].Length;
                    this.DoParse(startChr, endChr - startChr);
                }
                else if (this.Lines.Length == iLnCnt)
                    this.ParseCurrentLine();
                else
                    Parse();
                this.RaiseTextPaste();
            }
            catch (Exception ex)
            { System.Windows.Forms.MessageBox.Show(this, "Unable to paste text data:\n\n" + ex.Message + "\n\nApplication Version: " + System.Windows.Forms.Application.ProductVersion, "Error"); }
            finally
            { this._parsing = false; }
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            this.Parse();
        }
        protected override void OnSelectionChanged(EventArgs e)
        {
            base.OnSelectionChanged(e);

            if (this._parsing)
                return;

            if (this.SelectionLength == 0)
            {
                this.SuspendScroll();
                this.SuspendRefresh();

                int iSelStart = this.SelectionStart,
                    iSelLength = this.SelectionLength;
                this._parsing = true;

                try
                {
                    // Unbold any parenthesis we bolded last time.
                    //List<int> chgLns = new List<int>();
                    for (int i = 0; i < this._bldChars.Count; i++)
                    {
                        this.Select(this._bldChars[i], 1);
                        this.SelectionFont = this.Font;
                    }
                    this._bldChars.Clear();
                    this.Select(iSelStart, 0);

                    // Parse parenthasis here.
                    // Create a bolded version of the textbox's font to highlight
                    //   matching sets of parenthesis.
                    using (Font bFont = new Font(this.Font, FontStyle.Bold))
                    {
                        if (iSelStart > 2)
                        {
                            // If we're more than two char from the beginning of the document
                            //   then look backwards for parenthesis.
                            if (this.Text.Substring(iSelStart - 1, 1) == ")")
                            {
                                // If the character to the left of the cursor is a parenthesis
                                //   close, then look backwards for its mate.
                                int nestCnt = 0;
                                for (int i = iSelStart - 2; i >= 0; i--)
                                {
                                    string curChar = this.Text.Substring(i, 1);
                                    if (curChar == ")" && i > 0)
                                        nestCnt++;
                                    else if (curChar == "(" && nestCnt-- == 0)
                                    {
                                        // We found the matching open parenthesis.
                                        this.Select(i, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(i);
                                        this.Select(iSelStart - 1, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(iSelStart - 1);
                                        // We're done looking.
                                        break;
                                    }
                                }
                            }
                            else if (this.Text.Substring(iSelStart - 1, 1) == "]")
                            {
                                // If the character to the left of the cursor is a bracket
                                //   close, then look backwards for its mate.
                                int nestCnt = 0;
                                for (int i = iSelStart - 2; i >= 0; i--)
                                {
                                    string curChar = this.Text.Substring(i, 1);
                                    if (curChar == "]")
                                        nestCnt++;
                                    else if (curChar == "[" && nestCnt-- == 0)
                                    {
                                        // We found the matching open bracket.
                                        this.Select(i, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(i);
                                        this.Select(iSelStart - 1, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(iSelStart - 1);
                                        // We're done looking.
                                        break;
                                    }
                                }
                            }
                            else if (this.Text.Substring(iSelStart - 1, 1) == "}")
                            {
                                // If the character to the left of the cursor is a closing
                                //   brace, then look backwards for its mate.
                                int nestCnt = 0;
                                for (int i = iSelStart - 2; i >= 0; i--)
                                {
                                    string curChar = this.Text.Substring(i, 1);
                                    if (curChar == "}")
                                        nestCnt++;
                                    else if (curChar == "{" && nestCnt-- == 0)
                                    {
                                        // We found the matching open brace.
                                        this.Select(i, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(i);
                                        this.Select(iSelStart - 1, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(iSelStart - 1);
                                        // We're done looking.
                                        break;
                                    }
                                }
                            }
                        }
                        if (iSelStart < this.Text.Length - 3)
                        {
                            // If we're more than two characters form the end of the
                            //   document, then look forwards for parenthesis.
                            if (this.Text.Substring(iSelStart, 1) == "(")
                            {
                                // If the character to the right of the cursor is an
                                //   "Open Parenthesis", then search for its mate.
                                int iNestCnt = 0;
                                for (int i = iSelStart + 1; i <= this.Text.Length - 1; i++)
                                {
                                    string curChar = this.Text.Substring(i, 1);
                                    if (curChar == "(")
                                        iNestCnt++;
                                    else if (curChar == ")" && iNestCnt-- == 0)
                                    {
                                        // We found the matching close parenthesis
                                        this.Select(i, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(i);
                                        this.Select(iSelStart, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(iSelStart);
                                        // We're done looking.
                                        break;
                                    }
                                }
                            }
                            else if (this.Text.Substring(iSelStart, 1) == "[")
                            {
                                // If the character to the right of the cursor is an
                                //   "Open Bracket", then search for its mate.
                                int iNestCnt = 0;
                                for (int i = iSelStart + 1; i <= this.Text.Length - 1; i++)
                                {
                                    string curChar = this.Text.Substring(i, 1);
                                    if (curChar == "[")
                                        iNestCnt++;
                                    else if (curChar == "]" && iNestCnt-- == 0)
                                    {
                                        // We found the matching close bracket
                                        this.Select(i, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(i);
                                        this.Select(iSelStart, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(iSelStart);
                                        // We're done looking.
                                        break;
                                    }
                                }
                            }
                            else if (this.Text.Substring(iSelStart, 1) == "{")
                            {
                                // If the character to the right of the cursor is an
                                //   "Open Brace", then search for its mate.
                                int iNestCnt = 0;
                                for (int i = iSelStart + 1; i <= this.Text.Length - 1; i++)
                                {
                                    string curChar = this.Text.Substring(i, 1);
                                    if (curChar == "{")
                                        iNestCnt++;
                                    else if (curChar == "}" && iNestCnt-- == 0)
                                    {
                                        // We found the matching close bracket.
                                        this.Select(i, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(i);
                                        this.Select(iSelStart, 1);
                                        this.SelectionFont = bFont;
                                        this._bldChars.Add(iSelStart);
                                        // We're done looking.
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch { }
                finally
                {
                    if (this.SelectionStart != iSelStart || this.SelectionLength != iSelLength)
                        if (this._selDir == RainstormStudios.Controls.AdvRichTextBox.SelectDirection.Backword)
                            this.Select(iSelStart + iSelLength, -iSelLength);
                        else
                            this.Select(iSelStart, iSelLength);
                    this.SelectionFont = this.Font;
                    this.ResumeScroll();
                    this.ResumeRefresh();
                    this._parsing = false;
                }
            }
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (!this._parsing)
                base.OnPaint(e);
        }
        protected override void OnDragOver(System.Windows.Forms.DragEventArgs drgevent)
        {
            if (drgevent.Data.GetDataPresent(System.Windows.Forms.DataFormats.Text, true))
            {
                drgevent.Effect = System.Windows.Forms.DragDropEffects.Copy;
                base.OnDragOver(drgevent);
            }
            else
                drgevent.Effect = System.Windows.Forms.DragDropEffects.None;
        }
        protected override void OnDragDrop(System.Windows.Forms.DragEventArgs drgevent)
        {
            this._parsing = true;
            this.SuspendScroll();
            this.SuspendRefresh();

            try
            {
                if (this._internalDrag)
                {
                    base.OnDragDrop(drgevent);
                    this.AddUndo(new UndoState(UndoStateType.Move, (string)drgevent.Data.GetData(System.Windows.Forms.DataFormats.Text), "", this.GetCharIndexFromPosition(this.PointToClient(new Point(drgevent.X, drgevent.Y)))));
                    this._internalDrag = false;
                    this.Parse();
                }
                else if (drgevent.Data.GetDataPresent(System.Windows.Forms.DataFormats.Text, true))
                {
                    object objData = drgevent.Data.GetData(System.Windows.Forms.DataFormats.Text, true);
                    int iSelStart = this.SelectionStart,
                        iSelLength = this.SelectionLength;

                    base.OnDragDrop(drgevent);
                    this.AddUndo(new UndoState(UndoStateType.Drop, (string)drgevent.Data.GetData(System.Windows.Forms.DataFormats.Text), "", this.GetCharIndexFromPosition(this.PointToClient(new Point(drgevent.X, drgevent.Y)))));
                    this.Parse();
                }

                int drpLine = this.GetLineFromCharIndex(this.GetCharIndexFromPosition(new Point(drgevent.X, drgevent.Y)));
                this.DoParse(this.GetFirstCharIndexFromLine(drpLine), this.Lines[drpLine].Length + drgevent.Data.GetData(System.Windows.Forms.DataFormats.Text, true).ToString().Length);
            }
            finally
            {
                this._parsing = false;
                this.ResumeScroll();
                this.ResumeRefresh(true);
            }
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // This all helps to prevent scrolling or refreshing the text window
            //   while we're parsing for color, parenthesis, etc.
            if (this._parsing)
                if (m.Msg == (int)Win32Messages.WM_VSCROLL || m.Msg == (int)Win32Messages.WM_HSCROLL)
                    return;
                else if (m.Msg == (int)Win32Messages.EM_LINESCROLL || m.Msg == (int)Win32Messages.EM_SCROLL || m.Msg == (int)Win32Messages.EM_SCROLLCARET)
                    return;
                else if (m.Msg == (int)Win32Messages.WM_PAINT || m.Msg == (int)Win32Messages.WM_NCPAINT)
                    return;
                else if (m.Msg == (int)Win32Messages.WM_ERASEBKGND)
                    return;

            base.WndProc(ref m);
        }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == System.Windows.Forms.Keys.Insert)
            {
                this._insMode = (!this._insMode);
                this.OnInsertModeChanged(EventArgs.Empty);
            }
        }
        protected override void OnKeyUp(System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.V && e.Control)
                this.Paste();
            else if (e.KeyCode == System.Windows.Forms.Keys.C && e.Control)
                this.Copy();
            else if (e.KeyCode == System.Windows.Forms.Keys.X && e.Control)
                this.Cut();

            base.OnKeyUp(e);
        }
        //***************************************************************************
        // Event Triggers
        // 
        protected virtual void OnInsertModeChanged(EventArgs e)
        {
            if (this.InsertModeChanged != null)
                this.InsertModeChanged.Invoke(this, e);
        }
        protected virtual void OnTextParsed(EventArgs e)
        {
            if (this.TextParsed != null)
                this.TextParsed.Invoke(this, e);
        }
        #endregion
    }
}
