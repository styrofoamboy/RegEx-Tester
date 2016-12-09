using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RegexTester
{
    public partial class frmRgxDoc : DockContent
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private string
            _fn;
        private RainstormStudios.EventValueTypes.EventBoolean
            _saved;
        private bool
            _ovrWrite;
        //***************************************************************************
        // Public Events
        // 
        public event EventHandler InsertModeChanged;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string FileName
        {
            get { return System.IO.Path.GetFileName(this._fn); }
        }
        public string FilePath
        {
            get { return this._fn; }
            set { this._fn = value; }
        }
        public string[] RegExLines
        {
            get { return this.rgxTextBox.Lines; }
        }
        public string RegExText
        {
            get { return this.rgxTextBox.Text; }
            set { this.rgxTextBox.Text = value; }
        }
        public bool IsSaved
        {
            get { return this._saved.Value; }
        }
        public bool IsInsertMode
        {
            get { return this.rgxTextBox.IsInsertMode; }
        }
        public bool IsTextSelected
        {
            get { return this.rgxTextBox.SelectionLength > 0; }
        }
        public bool IsReadOnly
        {
            get { return this.rgxTextBox.ReadOnly; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmRgxDoc()
        {
            InitializeComponent();
            this._fn = string.Empty;
            this._saved = new RainstormStudios.EventValueTypes.EventBoolean(true);
            this._saved.ValueChanged += new EventHandler(this.saved_ValueChanged);
            this._ovrWrite = false;
        }
        public frmRgxDoc(string filePath)
            : this()
        {
            this.OpenFile(filePath);
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void SaveFile()
        {
            this.SaveFile(this._fn);
        }
        public void SaveFile(string fn)
        {
            try
            {
                if (string.IsNullOrEmpty(fn))
                    if (string.IsNullOrEmpty(fn = this.GetSaveFileName()))
                        return;

                bool firstSave = (this._fn != fn);
                this._fn = fn;
                using (System.IO.FileStream fs = new System.IO.FileStream(fn, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(fs))
                    for (int i = 0; i < this.rgxTextBox.Lines.Length; i++)
                        sr.WriteLine(this.rgxTextBox.Lines[i]);
                this._saved.Value = true;
                if (firstSave)
                    this.Text = this.FileName;
            }
            catch
            { throw; }
        }
        public void OpenFile(string filePath)
        {
            this._fn = filePath;
            if (System.IO.File.Exists(this._fn))
            {
                StringBuilder sb = new StringBuilder();
                using (System.IO.FileStream fs = new System.IO.FileStream(this._fn, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                using (System.IO.StreamReader sr = new System.IO.StreamReader(fs))
                    while (!sr.EndOfStream)
                        sb.AppendLine(sr.ReadLine());
                this.rgxTextBox.SuspendParse();
                this.rgxTextBox.Text = sb.ToString();
                this.Text = this.FileName;
                this._saved.Value = true;
                this.rgxTextBox.ResumeParse(true);
            }
        }
        public void CopyText()
        {
            this.rgxTextBox.Copy();
        }
        public void CutText()
        {
            this.rgxTextBox.Cut();
        }
        public void PasteText()
        {
            this.rgxTextBox.Paste();
        }
        public void DeleteText()
        {
            if (this.IsTextSelected)
                this.rgxTextBox.SelectedText = "";
        }
        public void SelectAllText()
        {
            this.rgxTextBox.SelectAll();
        }
        #endregion

        #region Non-Public Methods
        //***************************************************************************
        // Private Methods
        // 
        private string GetSaveFileName()
        {
            Application.DoEvents();
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.AddExtension = true;
                dlg.DefaultExt = ".rgx";
                dlg.Title = "Select File to Save";
                dlg.OverwritePrompt = true;
                dlg.Filter = "RegEx Query Files|*.rgx|All Files|*.*";
                dlg.FilterIndex = 0;
                dlg.ValidateNames = true;
                dlg.SupportMultiDottedExtensions = true;
                if (dlg.ShowDialog(this.FindForm()) == DialogResult.OK)
                    return dlg.FileName;
                else
                    return string.Empty;
            }
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuCut":
                    this.rgxTextBox.Cut();
                    break;
                case "mnuCopy":
                    this.rgxTextBox.Copy();
                    break;
                case "mnuPaste":
                    this.rgxTextBox.Paste();
                    break;
                case "mnuDelete":
                    if (this.IsTextSelected)
                        this.rgxTextBox.SelectedText = "";
                    break;
                case "mnuSelectAll":
                    this.rgxTextBox.SelectAll();
                    break;
            }
        }
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            // The Copy command just requires that some text be highlighted.
            this.contextMenu.Items["mnuCopy"].Enabled = (this.rgxTextBox.SelectionLength > 0);
            // The Cut and Delete commands require that text be highlighted *and*
            //   that the control is not in ReadOnly mode.
            this.contextMenu.Items["mnuCut"].Enabled =
                this.contextMenu.Items["mnuDelete"].Enabled = (this.rgxTextBox.SelectionLength > 0) && (!this.rgxTextBox.ReadOnly);
            // The Paste command requires that the control is not in ReadOnly mode.
            this.contextMenu.Items["mnuPaste"].Enabled = (Clipboard.ContainsText()) && (!this.rgxTextBox.ReadOnly);
            // And the Undo command requires that there's something in the undo
            //   buffer to act on.
            this.contextMenu.Items[0].Enabled = (this.rgxTextBox.UndoLevelCount > 0);
        }
        private void rgxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this._saved)
                this._saved.Value = false;
        }
        private void saved_ValueChanged(object sender, EventArgs e)
        {
            if (!this._saved)
                this.Text += " *";
            else
                this.Text = this.Text.TrimEnd('*', ' ');
        }
        private void rgxTextBox_InsertModeChanged(object sender, EventArgs e)
        {
            if (this.InsertModeChanged != null)
                this.InsertModeChanged.Invoke(this, e);
        }
        //***************************************************************************
        // Form Event Overrides
        // 
        protected override void OnClosing(CancelEventArgs e)
        {
            if (!this._saved)
            {
                Form frmParent = this.FindForm();
                this.Activate();
                DialogResult dlgRslt = MessageBox.Show(frmParent, "This document contains unsaved changes.  Would you like to save your changes before closing the document?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dlgRslt == DialogResult.Cancel)
                    e.Cancel = true;
                else if (dlgRslt == DialogResult.Yes)
                    this.SaveFile();
            }

            base.OnClosing(e);
        }
        #endregion
    }
}
