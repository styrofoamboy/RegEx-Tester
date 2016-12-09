using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexTester
{
    public partial class frmMain : Form
    {
        #region Declarations
        //***************************************************************************
        // Constants
        // 
        static readonly string
            xmlInitLayoutFn = System.IO.Path.Combine(Application.StartupPath, "initlayout.xml");
        //const string
        //    userRegLayout = "LayoutHint";
        static readonly string
            xmlLayoutFn = System.IO.Path.Combine(Application.StartupPath, "layout.xml");
        //***************************************************************************
        // Private Fields
        // 
        private WeifenLuo.WinFormsUI.Docking.DeserializeDockContent 
            m_deserializeDockContent;
        private frmInputSrc 
            m_frmSrc;
        private frmMatches
            m_frmMatch;
        //private frmRgxDoc
        //    m_frmRgxDoc1;
        private DateTime
            dtRegExStart;
        private WeifenLuo.WinFormsUI.Docking.IDockContent
            _lastActiveRgx;
        //***************************************************************************
        // Delegates
        // 
        private delegate int ExecMatchDelegate();
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public WeifenLuo.WinFormsUI.Docking.DockPanel DockPanel
        {
            get { return this.dockPanel; }
        }
        //***************************************************************************
        // Private Properties
        // 
        private frmRgxDoc ActiveDocument
        {
            get { return (frmRgxDoc)this.dockPanel.ActiveDocument; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmMain()
        {
            InitializeComponent();
            this.m_deserializeDockContent = new WeifenLuo.WinFormsUI.Docking.DeserializeDockContent(this.GetContentFromPersistString);
            this.InitDockPanels();
        }
        #endregion

        #region Private methods
        //***************************************************************************
        // Private Methods
        // 
        private void InitDockPanels()
        {
            this.dockPanel.ActiveDocumentChanged += new EventHandler(dockPanel_ActiveDocumentChanged);

            m_frmSrc = new frmInputSrc();
            m_frmSrc.Text = "Input Text";
            m_frmSrc.CloseButton = false;
            m_frmSrc.AllowEndUserDocking = true;

            m_frmMatch = new frmMatches();
            m_frmMatch.Text = "Matches";
            m_frmMatch.CloseButton = false;
            m_frmMatch.AllowEndUserDocking = true;
            m_frmMatch.TreeNodeSelectionChanged += new TreeViewEventHandler(m_frmMatch_TreeNodeSelectionChanged);

            if (!this.LoadLayout())
            {
                m_frmSrc.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Float);
                m_frmMatch.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Float);
            }
            this.CreateNewDoc();
        }
        private frmRgxDoc CreateNewDoc()
        {
            frmRgxDoc frmRgxDoc00 = new frmRgxDoc();
            frmRgxDoc00.Text = "Untitled" + (this.dockPanel.DocumentsCount + 1).ToString().PadLeft(2, '0');
            frmRgxDoc00.Name = frmRgxDoc00.Text;
            frmRgxDoc00.CloseButton = true;
            frmRgxDoc00.TabPageContextMenuStrip = this.mnuDocTabs;
            frmRgxDoc00.AllowEndUserDocking = true;
            frmRgxDoc00.MdiParent = this;
            frmRgxDoc00.InsertModeChanged += new EventHandler(this.rgxDoc_InsertModeChanged);
            frmRgxDoc00.Show(this.dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);
            return frmRgxDoc00;
        }
        private void SaveLayout()
        {
            try
            {
                this.dockPanel.SaveAsXml(xmlLayoutFn);
            }
            catch (Exception ex)
            { RainstormStudios.Logger.Instance.WriteToLog(new RainstormStudios.LogMessage(RainstormStudios.SeverityLevel.Error, "Error saving window layout: " + ex.Message, "frmMain+SaveLayout")); }
        }
        private bool LoadLayout()
        {
            try
            {
                if (!System.IO.File.Exists(xmlLayoutFn) && System.IO.File.Exists(xmlInitLayoutFn))
                {
                    // If the user doesn't have a "custom" layout.xml, load the initial layout file.
                    try
                    {
                        this.dockPanel.LoadFromXml(xmlInitLayoutFn, this.m_deserializeDockContent);
                        return true;
                    }
                    catch
                    { return false; }
                }
                else if (System.IO.File.Exists(xmlLayoutFn))
                {
                    this.dockPanel.LoadFromXml(xmlLayoutFn, this.m_deserializeDockContent);
                    return true;
                }
                return false;
                
            }
            catch (Exception ex)
            {
                RainstormStudios.Logger.Instance.WriteToLog(new RainstormStudios.LogMessage(RainstormStudios.SeverityLevel.Error, "Error loading window layout: " + ex.Message, "frmMain+LoadLayout"));
                return false;
            }
        }
        private RegexOptions GetRegExOpts()
        {
            // Determine which RegExOptions to assign to this operation based on the
            //   ToolBarButtons' statuses.
            RegexOptions rgxOpts = RegexOptions.None;
            if (this.tbbModeEcma.Checked)
                rgxOpts |= RegexOptions.ECMAScript;
            if (this.tbbModeExplicitCapture.Checked)
                rgxOpts |= RegexOptions.ExplicitCapture;
            if (this.tbbModeIgnoreCase.Checked)
                rgxOpts |= RegexOptions.IgnoreCase;
            if (this.tbbModeIgnoreWhitespace.Checked)
                rgxOpts |= RegexOptions.IgnorePatternWhitespace;
            if (this.tbbModeMultiline.Checked)
                rgxOpts |= RegexOptions.Multiline;
            if (this.tbbModeRightToLeft.Checked)
                rgxOpts |= RegexOptions.RightToLeft;
            if (this.tbbModeSingleLine.Checked)
                rgxOpts |= RegexOptions.Singleline;

            return rgxOpts;
        }
        private string GetActiveRegEx()
        {
            if (this._lastActiveRgx != null && this._lastActiveRgx is frmRgxDoc)
                return Convert.ToString(RainstormStudios.CrossThreadUI.GetPropertyInstance((frmRgxDoc)this._lastActiveRgx, "RegExText"));
            else
                foreach (var doc in dockPanel.Documents)
                    if (doc is frmRgxDoc)
                        return Convert.ToString(RainstormStudios.CrossThreadUI.GetPropertyInstance((frmRgxDoc)doc, "RegExText"));
            return null;
        }
        private string GetCurrentSourceInput()
        {
            return Convert.ToString(RainstormStudios.CrossThreadUI.GetPropertyInstance(this.m_frmSrc, "InputText"));
        }
        private WeifenLuo.WinFormsUI.Docking.IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(frmMatches).ToString())
                return m_frmMatch;
            else if (persistString == typeof(frmInputSrc).ToString())
                return m_frmSrc;
            else
            {
                //// DummyDoc overrides GetPersistString to add extra information into persistString.
                //// Any DockContent may override this value to add any needed information for deserialization.

                //string[] parsedStrings = persistString.Split(new char[] { ',' });
                //if (parsedStrings.Length != 3)
                //    return null;

                //if (parsedStrings[0] != typeof(frmRgxDoc).ToString())
                //    return null;

                //frmRgxDoc rgxDoc = (!string.IsNullOrEmpty(parsedStrings[1]))
                //                        ? new frmRgxDoc(parsedStrings[1])
                //                        : new frmRgxDoc();

                //return rgxDoc;
                return null;
            }
        }
        private void BeginMatch()
        {
            ExecMatchDelegate del = new ExecMatchDelegate(this.ExecMatch);
            del.BeginInvoke(new AsyncCallback(this.ExecMatchCallBack), del);
        }
        private void SaveRgx()
        {
            ((frmRgxDoc)this.dockPanel.ActiveDocument).SaveFile();
        }
        private void SaveRgxAs()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = ".rgx";
                dlg.AddExtension = true;
                dlg.AutoUpgradeEnabled = true;
                dlg.Filter = "RegEx Query Files|*.rgx;*.txt|All Files|*.*";
                dlg.FilterIndex = 0;
                dlg.OverwritePrompt = true;
                dlg.Title = "Save File As...";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                    ((frmRgxDoc)this.dockPanel.ActiveDocument).SaveFile(dlg.FileName);
            }
        }
        private void OpenRgx()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select File to Open";
                dlg.AddExtension = true;
                dlg.DefaultExt = ".rgx";
                dlg.Filter = "Regular Expression Files|*.rgx;*.txt|All Files|*.*";
                dlg.FilterIndex = 0;
                dlg.Multiselect = true;
                dlg.ValidateNames = true;
                dlg.SupportMultiDottedExtensions = true;
                dlg.CheckFileExists = true;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    // Grab the currently active document.
                    frmRgxDoc curDoc = ((frmRgxDoc)this.dockPanel.ActiveDocument);
                    // If the document is blank and the status "IsSaved" = true, then
                    //   it means the user hasen't altered the doc, so we're going to
                    //   replace it.
                    if (curDoc == null || (string.IsNullOrEmpty(curDoc.RegExText) && curDoc.IsSaved))
                        curDoc.Close();

                    // Open each file selected in the dialog.
                    for (int i = 0; i < dlg.FileNames.Length; i++)
                    {
                        frmRgxDoc newDoc = this.CreateNewDoc();
                        newDoc.OpenFile(dlg.FileNames[i]);
                    }
                }
            }
        }
        private void UpdateInsertMode()
        {
            if (this.dockPanel.ActiveDocument != null)
                if (this.dockPanel.ActiveDocument is frmRgxDoc)
                {
                    this._lastActiveRgx = this.dockPanel.ActiveDocument;
                    this.statusLblInsMode.Text = (((frmRgxDoc)this.dockPanel.ActiveDocument).IsInsertMode) ? "OVR" : "INS";
                }
        }
        private void CompileAssembly(string asmFileNm, string Nmspc, string classNm, string protLvl, bool allDocs)
        {
            char[] invalidClassChars = new char[] { '*', ' ', '#', '$', '%', '(', ')', '@', '!', '[', ']', '{', '}', '<', '>', ',', ';', '.' };

            try
            {
                if (this.dockPanel.DocumentsCount < 1)
                    throw new Exception("No open documents.");

                List<RegexCompilationInfo> lstRgxInfos = new List<RegexCompilationInfo>();

                if (allDocs)
                {
                    foreach (WeifenLuo.WinFormsUI.Docking.IDockContent iRgxDoc in this.dockPanel.Documents)
                    {
                        frmRgxDoc doc = (iRgxDoc as frmRgxDoc);

                        if (doc == null)
                            continue;

                        string rgxText = doc.RegExText;
                        string rgxName = System.IO.Path.GetFileNameWithoutExtension(RainstormStudios.rsString.RemoveChars(doc.Text, invalidClassChars));
                        System.Text.RegularExpressions.RegexCompilationInfo compInfo = new RegexCompilationInfo(rgxText, this.GetRegExOpts(), rgxName, Nmspc, (protLvl.ToLower() == "public"));
                        lstRgxInfos.Add(compInfo);
                    }
                }
                else
                {
                    frmRgxDoc doc = (this.dockPanel.ActiveDocument as frmRgxDoc);
                    if (doc == null)
                        throw new Exception("No active document.");

                    string rgxText = doc.RegExText;
                    string rgxName = RainstormStudios.rsString.RemoveChars(doc.Text, invalidClassChars);
                    System.Text.RegularExpressions.RegexCompilationInfo compInfo = new RegexCompilationInfo(rgxText, this.GetRegExOpts(), rgxName, Nmspc, (protLvl.ToLower() == "public"));
                }

                System.Reflection.AssemblyName asmName = new System.Reflection.AssemblyName();
                asmName.CultureInfo = System.Globalization.CultureInfo.CurrentCulture;
                asmName.Name = System.IO.Path.GetFileNameWithoutExtension(asmFileNm);
                asmName.Version = new Version(1, 0);
                asmName.VersionCompatibility = System.Configuration.Assemblies.AssemblyVersionCompatibility.SameProcess;

                Regex.CompileToAssembly(lstRgxInfos.ToArray(), asmName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "An unexpected error has occured while trying to create the regular expression assembly:\n\n" + ex.Message + "\n\nApplication Version: " + Application.ProductVersion, "Unexpected Error");
            }
        }
        //***************************************************************************
        // Thread-Worker Methods
        // 
        private int ExecMatch()
        {
            // Disable the document.
            //RainstormStudios.CrossThreadUI.SetEnabled((frmRgxDoc)this.dockPanel.ActiveDocument, false);

            // Show the "Waiting Anim".
            RainstormStudios.CrossThreadUI.SetVisible(this.animWidgetRotator1, true);

            // Record the time we started the RegEx match operation.
            this.dtRegExStart = DateTime.Now;

            // Get the RegEx string from the active document and any source text
            //   entered into the InputSource panel.
            string rgxStr = this.GetActiveRegEx();
            if (string.IsNullOrEmpty(rgxStr))
                return 0;

            string srcStr = this.GetCurrentSourceInput();

            // Get the RegEx options.
            RegexOptions rgxOpts = this.GetRegExOpts();

            // This will be the thread's return value.
            int totalMatches = 0;

            // Now it's time to build the RegEx object and execute the match.
            try
            {
                Regex rgx = new Regex(rgxStr, rgxOpts);
                string[] groupNms = rgx.GetGroupNames();
                Match m;
                RainstormStudios.CrossThreadUI.InvokeMethod(this.m_frmMatch, "BeginUpdate");
                RainstormStudios.CrossThreadUI.InvokeMethod(this.m_frmMatch, "Clear");
                for (m = rgx.Match(srcStr); m.Success; m = m.NextMatch())
                {
                    //this.m_frmMatch.AddRegExMatch(m);
                    RainstormStudios.CrossThreadUI.InvokeMethod(this.m_frmMatch, "AddRegExMatch", m, groupNms);
                    totalMatches++;
                }
            }
            catch (Exception ex)
            {
                // If something crashes, just show a message box.
                RainstormStudios.CrossThreadUI.ShowMessageBox(this, "Unable to execute regex:\n\n" + ex.Message, "RegEx Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                // Resume redraw on the TreeView.
                RainstormStudios.CrossThreadUI.InvokeMethod(this.m_frmMatch, "EndUpdate");
            }
            // Return the totalMatches counter.
            return totalMatches;
        }
        private void ExecMatchCallBack(IAsyncResult state)
        {
            ExecMatchDelegate del = (ExecMatchDelegate)state.AsyncState;
            int totalMatches = del.EndInvoke(state);
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLbllMatches, "Text", "Matches: " + totalMatches.ToString());
            RainstormStudios.CrossThreadUI.SetPropertyValue(this.statusLblLastMatch, "Text", "Last Match: " + Math.Round(DateTime.Now.Subtract(this.dtRegExStart).TotalSeconds, 2).ToString());
            RainstormStudios.CrossThreadUI.SetVisible(this.animWidgetRotator1, false);
            //RainstormStudios.CrossThreadUI.SetEnabled((frmRgxDoc)this.dockPanel.ActiveDocument, true);
            this.dtRegExStart = DateTime.MinValue;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Form Overrides
        // 
        protected override void OnClosing(CancelEventArgs e)
        {
            // The individual documents themselves confirm being closed without
            //   being saved, so we don't need to worry about that here.

            // If we're not canceling the close operation, then save the layout
            //   to the registry.
            if(!e.Cancel)
                this.SaveLayout();

            base.OnClosing(e);
        }
        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.F5)
                this.BeginMatch();
        }
        //***************************************************************************
        // Event Handlers
        // 
        private void m_frmMatch_TreeNodeSelectionChanged(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                // This is a root match node.
                MatchInfo mi = this.m_frmMatch.GetNodeMatch(e.Node);
                if (!mi.Equals(MatchInfo.Empty))
                    this.m_frmSrc.Highlight(mi.Start, mi.Length, Color.Yellow);
            }
            else
            {
                // This is a group node.
                MatchInfo mi = this.m_frmMatch.GetNodeMatch(e.Node.Parent);
                if (!mi.Equals(MatchInfo.Empty))
                {
                    GroupInfo gi = mi.Groups[e.Node.Tag.ToString()];
                    this.m_frmSrc.Highlight(gi.Start, gi.Length, Color.Green);
                }
            }
        }
        private void mnuFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuFileNew":
                    this.CreateNewDoc();
                    break;
                case "mnuFileSave":
                    this.SaveRgx();
                    break;
                case "mnuFileSaveAs":
                    this.SaveRgxAs();
                    break;
                case "mnuFileOpen":
                    this.OpenRgx();
                    break;
                case "mnuFilePref":
                    break;
                case "mnuFileQuit":
                    this.Close();
                    break;
            }
        }
        private void mnuEdit_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuEditCut":
                    this.ActiveDocument.CutText();
                    break;
                case "mnuEditCopy":
                    this.ActiveDocument.CopyText();
                    break;
                case "mnuEditPaste":
                    this.ActiveDocument.PasteText();
                    break;
                case "mnuEditDelete":
                    this.ActiveDocument.DeleteText();
                    break;
            }
        }
        private void mnuEdit_DropDownOpening(object sender, EventArgs e)
        {
            frmRgxDoc activeDoc = (this.dockPanel.ActiveDocument as frmRgxDoc);
            bool txtSelected = (activeDoc == null)
                                ? false
                                : activeDoc.IsTextSelected;
            this.mnuEditCut.Enabled =
                this.mnuEditCopy.Enabled =
                this.mnuEditDelete.Enabled = txtSelected;
            this.mnuEditPaste.Enabled = (activeDoc != null) && (!activeDoc.IsReadOnly) && (Clipboard.ContainsText());
            this.mnuEditSelectAll.Enabled = (activeDoc != null);
        }
        private void mnuDocument_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuDocumentMatch":
                    this.BeginMatch();
                    break;
                case "mnuDocumentReplace":
                    break;
                case "mnuDocumentSplit":
                    break;
            }
        }
        private void mnuTools_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuToolsCompileAsm":
                    {
                        frmRgxDoc doc = (frmRgxDoc)this.dockPanel.ActiveDocument;
                        string asmDetBase = string.Empty;
                        if (!string.IsNullOrEmpty(doc.FileName))
                            asmDetBase = System.IO.Path.GetFileNameWithoutExtension(doc.FileName);
                        using (frmCompileAsm frm = new frmCompileAsm(asmDetBase, "Match" + asmDetBase, asmDetBase))
                            if (frm.ShowDialog(this) == DialogResult.OK)
                                this.CompileAssembly(frm.AssemblyName, frm.NamespaceName, frm.ClassName, frm.ProtectionLevel, frm.AllActiveDocs);
                        break;
                    }
                case "mnuToolsGenCode":
                    break;
            }
        }
        private void mnuWindow_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
            }
        }
        private void mnuHelp_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuHelpContents":
                    MessageBox.Show(this, "Sorry.", "Not Available");
                    break;
                case "mnuHelpAbout":
                    using (frmAbout frm = new frmAbout())
                        frm.ShowDialog(this);
                    break;
            }
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tbbNew":
                    this.CreateNewDoc();
                    break;
                case "tbbOpen":
                    this.OpenRgx();
                    break;
                case "tbbSave":
                    this.SaveRgx();
                    break;
                case "tbbMatch":
                    this.BeginMatch();
                    break;
            }
        }
        private void mnuStripDocTabs_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.mnuDocTabs.Close(ToolStripDropDownCloseReason.ItemClicked);
            switch (e.ClickedItem.Name)
            {
                case "mnuDocTabClose":
                    {
                        frmRgxDoc frmDoc = (frmRgxDoc)this.dockPanel.ActiveDocument;
                        frmDoc.Close();
                    }
                    break;
                case "mnuDocTabSave":
                    ((frmRgxDoc)this.dockPanel.ActiveDocument).SaveFile();
                    break;
                case "mnuDocTabOpenFolder":
                    break;
            }
        }
        private void rgxDoc_InsertModeChanged(object sender, EventArgs e)
        {
            this.UpdateInsertMode();
        }
        private void dockPanel_ActiveDocumentChanged(object sender, EventArgs e)
        {
            this.UpdateInsertMode();
        }
#if DEBUG
        private void mnuDebug_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuDebugSaveLayout":
                    this.dockPanel.SaveAsXml(xmlInitLayoutFn);
                    break;
                case "mnuDebugClearLayout":
                    if (System.IO.File.Exists(xmlLayoutFn))
                        System.IO.File.Delete(xmlLayoutFn);
                    break;
            }
        }
#endif
        #endregion
    }
}
