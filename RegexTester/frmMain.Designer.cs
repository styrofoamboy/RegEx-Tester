namespace RegexTester
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFilePref = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocumentMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocumentReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocumentSplit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsCompileAsm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolsGenCode = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
#if DEBUG
            this.mnuDebugSaveLayout = new System.Windows.Forms.ToolStripMenuItem();
#endif
            this.loadLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearUserLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbbNew = new System.Windows.Forms.ToolStripButton();
            this.tbbSave = new System.Windows.Forms.ToolStripButton();
            this.tbbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbMatch = new System.Windows.Forms.ToolStripButton();
            this.tbbReplace = new System.Windows.Forms.ToolStripButton();
            this.tbbSplit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbbModeIgnoreCase = new System.Windows.Forms.ToolStripButton();
            this.tbbModeMultiline = new System.Windows.Forms.ToolStripButton();
            this.tbbModeSingleLine = new System.Windows.Forms.ToolStripButton();
            this.tbbModeIgnoreWhitespace = new System.Windows.Forms.ToolStripButton();
            this.tbbModeRightToLeft = new System.Windows.Forms.ToolStripButton();
            this.tbbModeExplicitCapture = new System.Windows.Forms.ToolStripButton();
            this.tbbModeEcma = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLbllMatches = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLblLastMatch = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLblInsMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mnuDocTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDocTabSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocTabClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDocTabOpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.animWidgetRotator1 = new RainstormStudios.Controls.AnimWidgetRotator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mnuDocTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuDocument,
            this.mnuTools,
            this.mnuWindow,
            this.mnuHelp,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileOpen,
            this.mnuFileRecent,
            this.toolStripSeparator1,
            this.mnuFilePref,
            this.toolStripMenuItem1,
            this.mnuFileQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuFile_DropDownItemClicked);
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(136, 22);
            this.mnuFileNew.Text = "New";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(136, 22);
            this.mnuFileSave.Text = "Save";
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(136, 22);
            this.mnuFileSaveAs.Text = "Save As...";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(136, 22);
            this.mnuFileOpen.Text = "Open";
            // 
            // mnuFileRecent
            // 
            this.mnuFileRecent.Name = "mnuFileRecent";
            this.mnuFileRecent.Size = new System.Drawing.Size(136, 22);
            this.mnuFileRecent.Text = "Recent Files";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // mnuFilePref
            // 
            this.mnuFilePref.Name = "mnuFilePref";
            this.mnuFilePref.Size = new System.Drawing.Size(136, 22);
            this.mnuFilePref.Text = "Preferences";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(136, 22);
            this.mnuFileQuit.Text = "Quit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.mnuEditDelete,
            this.toolStripMenuItem3,
            this.mnuEditSelectAll});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.DropDownOpening += new System.EventHandler(this.mnuEdit_DropDownOpening);
            this.mnuEdit.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuEdit_DropDownItemClicked);
            // 
            // mnuEditCut
            // 
            this.mnuEditCut.Name = "mnuEditCut";
            this.mnuEditCut.Size = new System.Drawing.Size(122, 22);
            this.mnuEditCut.Text = "Cut";
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.Name = "mnuEditCopy";
            this.mnuEditCopy.Size = new System.Drawing.Size(122, 22);
            this.mnuEditCopy.Text = "Copy";
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.Name = "mnuEditPaste";
            this.mnuEditPaste.Size = new System.Drawing.Size(122, 22);
            this.mnuEditPaste.Text = "Paste";
            // 
            // mnuEditDelete
            // 
            this.mnuEditDelete.Name = "mnuEditDelete";
            this.mnuEditDelete.Size = new System.Drawing.Size(122, 22);
            this.mnuEditDelete.Text = "Delete";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(119, 6);
            // 
            // mnuEditSelectAll
            // 
            this.mnuEditSelectAll.Name = "mnuEditSelectAll";
            this.mnuEditSelectAll.Size = new System.Drawing.Size(122, 22);
            this.mnuEditSelectAll.Text = "Select All";
            // 
            // mnuDocument
            // 
            this.mnuDocument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDocumentMatch,
            this.mnuDocumentReplace,
            this.mnuDocumentSplit});
            this.mnuDocument.Name = "mnuDocument";
            this.mnuDocument.Size = new System.Drawing.Size(75, 20);
            this.mnuDocument.Text = "Document";
            this.mnuDocument.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuDocument_DropDownItemClicked);
            // 
            // mnuDocumentMatch
            // 
            this.mnuDocumentMatch.Name = "mnuDocumentMatch";
            this.mnuDocumentMatch.Size = new System.Drawing.Size(115, 22);
            this.mnuDocumentMatch.Text = "Match";
            // 
            // mnuDocumentReplace
            // 
            this.mnuDocumentReplace.Enabled = false;
            this.mnuDocumentReplace.Name = "mnuDocumentReplace";
            this.mnuDocumentReplace.Size = new System.Drawing.Size(115, 22);
            this.mnuDocumentReplace.Text = "Replace";
            // 
            // mnuDocumentSplit
            // 
            this.mnuDocumentSplit.Enabled = false;
            this.mnuDocumentSplit.Name = "mnuDocumentSplit";
            this.mnuDocumentSplit.Size = new System.Drawing.Size(115, 22);
            this.mnuDocumentSplit.Text = "Split";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolsCompileAsm,
            this.mnuToolsGenCode});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "Tools";
            this.mnuTools.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuTools_DropDownItemClicked);
            // 
            // mnuToolsCompileAsm
            // 
            this.mnuToolsCompileAsm.Name = "mnuToolsCompileAsm";
            this.mnuToolsCompileAsm.Size = new System.Drawing.Size(187, 22);
            this.mnuToolsCompileAsm.Text = "Compile to Assembly";
            // 
            // mnuToolsGenCode
            // 
            this.mnuToolsGenCode.Name = "mnuToolsGenCode";
            this.mnuToolsGenCode.Size = new System.Drawing.Size(187, 22);
            this.mnuToolsGenCode.Text = "Generate Code";
            // 
            // mnuWindow
            // 
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "Window";
            this.mnuWindow.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuWindow_DropDownItemClicked);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpContents,
            this.toolStripMenuItem2,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuHelp_DropDownItemClicked);
            // 
            // mnuHelpContents
            // 
            this.mnuHelpContents.Name = "mnuHelpContents";
            this.mnuHelpContents.Size = new System.Drawing.Size(122, 22);
            this.mnuHelpContents.Text = "Contents";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(122, 22);
            this.mnuHelpAbout.Text = "About";
            // 
            // debugToolStripMenuItem
            // 
#if DEBUG
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDebugSaveLayout,
            this.loadLayoutToolStripMenuItem,
            this.toolStripMenuItem5,
            this.clearUserLayoutToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // mnuDebugSaveLayout
            // 
            this.mnuDebugSaveLayout.Name = "mnuDebugSaveLayout";
            this.mnuDebugSaveLayout.Size = new System.Drawing.Size(166, 22);
            this.mnuDebugSaveLayout.Text = "Save Layout";
#endif
            // 
            // loadLayoutToolStripMenuItem
            // 
            this.loadLayoutToolStripMenuItem.Name = "loadLayoutToolStripMenuItem";
            this.loadLayoutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.loadLayoutToolStripMenuItem.Text = "Load Layout";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(163, 6);
            // 
            // clearUserLayoutToolStripMenuItem
            // 
            this.clearUserLayoutToolStripMenuItem.Name = "clearUserLayoutToolStripMenuItem";
            this.clearUserLayoutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearUserLayoutToolStripMenuItem.Text = "Clear User Layout";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbNew,
            this.tbbSave,
            this.tbbOpen,
            this.toolStripSeparator2,
            this.tbbMatch,
            this.tbbReplace,
            this.tbbSplit,
            this.toolStripSeparator3,
            this.tbbModeIgnoreCase,
            this.tbbModeMultiline,
            this.tbbModeSingleLine,
            this.tbbModeIgnoreWhitespace,
            this.tbbModeRightToLeft,
            this.tbbModeExplicitCapture,
            this.tbbModeEcma});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tbbNew
            // 
            this.tbbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbNew.Image = global::RegexTester.Properties.Resources.page_add;
            this.tbbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbNew.Name = "tbbNew";
            this.tbbNew.Size = new System.Drawing.Size(23, 22);
            this.tbbNew.Text = "New Document";
            // 
            // tbbSave
            // 
            this.tbbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbSave.Image = global::RegexTester.Properties.Resources.page_save;
            this.tbbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbSave.Name = "tbbSave";
            this.tbbSave.Size = new System.Drawing.Size(23, 22);
            this.tbbSave.Text = "Save";
            // 
            // tbbOpen
            // 
            this.tbbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbOpen.Image = global::RegexTester.Properties.Resources.folder_page1;
            this.tbbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbOpen.Name = "tbbOpen";
            this.tbbOpen.Size = new System.Drawing.Size(23, 22);
            this.tbbOpen.Text = "Open";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbMatch
            // 
            this.tbbMatch.Image = global::RegexTester.Properties.Resources.application_go;
            this.tbbMatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbMatch.Name = "tbbMatch";
            this.tbbMatch.Size = new System.Drawing.Size(61, 22);
            this.tbbMatch.Text = "Match";
            // 
            // tbbReplace
            // 
            this.tbbReplace.Enabled = false;
            this.tbbReplace.Image = ((System.Drawing.Image)(resources.GetObject("tbbReplace.Image")));
            this.tbbReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbReplace.Name = "tbbReplace";
            this.tbbReplace.Size = new System.Drawing.Size(68, 22);
            this.tbbReplace.Text = "Replace";
            // 
            // tbbSplit
            // 
            this.tbbSplit.Enabled = false;
            this.tbbSplit.Image = ((System.Drawing.Image)(resources.GetObject("tbbSplit.Image")));
            this.tbbSplit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbSplit.Name = "tbbSplit";
            this.tbbSplit.Size = new System.Drawing.Size(50, 22);
            this.tbbSplit.Text = "Split";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbbModeIgnoreCase
            // 
            this.tbbModeIgnoreCase.Checked = true;
            this.tbbModeIgnoreCase.CheckOnClick = true;
            this.tbbModeIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbbModeIgnoreCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbModeIgnoreCase.Image = global::RegexTester.Properties.Resources.text_smallcaps;
            this.tbbModeIgnoreCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbModeIgnoreCase.Name = "tbbModeIgnoreCase";
            this.tbbModeIgnoreCase.Size = new System.Drawing.Size(23, 22);
            this.tbbModeIgnoreCase.Text = "Ignore Case";
            // 
            // tbbModeMultiline
            // 
            this.tbbModeMultiline.CheckOnClick = true;
            this.tbbModeMultiline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbModeMultiline.Image = global::RegexTester.Properties.Resources.text_padding_left;
            this.tbbModeMultiline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbModeMultiline.Name = "tbbModeMultiline";
            this.tbbModeMultiline.Size = new System.Drawing.Size(23, 22);
            this.tbbModeMultiline.Text = "Multi-Line";
            // 
            // tbbModeSingleLine
            // 
            this.tbbModeSingleLine.Checked = true;
            this.tbbModeSingleLine.CheckOnClick = true;
            this.tbbModeSingleLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbbModeSingleLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbModeSingleLine.Image = global::RegexTester.Properties.Resources.text_padding_top;
            this.tbbModeSingleLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbModeSingleLine.Name = "tbbModeSingleLine";
            this.tbbModeSingleLine.Size = new System.Drawing.Size(23, 22);
            this.tbbModeSingleLine.Text = "Single Line";
            // 
            // tbbModeIgnoreWhitespace
            // 
            this.tbbModeIgnoreWhitespace.Checked = true;
            this.tbbModeIgnoreWhitespace.CheckOnClick = true;
            this.tbbModeIgnoreWhitespace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tbbModeIgnoreWhitespace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbModeIgnoreWhitespace.Image = global::RegexTester.Properties.Resources.text_columns;
            this.tbbModeIgnoreWhitespace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbModeIgnoreWhitespace.Name = "tbbModeIgnoreWhitespace";
            this.tbbModeIgnoreWhitespace.Size = new System.Drawing.Size(23, 22);
            this.tbbModeIgnoreWhitespace.Text = "Ignore Whitespace";
            // 
            // tbbModeRightToLeft
            // 
            this.tbbModeRightToLeft.CheckOnClick = true;
            this.tbbModeRightToLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbModeRightToLeft.Image = global::RegexTester.Properties.Resources.text_indent_remove;
            this.tbbModeRightToLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbModeRightToLeft.Name = "tbbModeRightToLeft";
            this.tbbModeRightToLeft.Size = new System.Drawing.Size(23, 22);
            this.tbbModeRightToLeft.Text = "Right to Left";
            // 
            // tbbModeExplicitCapture
            // 
            this.tbbModeExplicitCapture.CheckOnClick = true;
            this.tbbModeExplicitCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbModeExplicitCapture.Image = global::RegexTester.Properties.Resources.script_code_red;
            this.tbbModeExplicitCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbModeExplicitCapture.Name = "tbbModeExplicitCapture";
            this.tbbModeExplicitCapture.Size = new System.Drawing.Size(23, 22);
            this.tbbModeExplicitCapture.Text = "Explicit Capture";
            // 
            // tbbModeEcma
            // 
            this.tbbModeEcma.CheckOnClick = true;
            this.tbbModeEcma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbbModeEcma.Image = ((System.Drawing.Image)(resources.GetObject("tbbModeEcma.Image")));
            this.tbbModeEcma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbbModeEcma.Name = "tbbModeEcma";
            this.tbbModeEcma.Size = new System.Drawing.Size(23, 22);
            this.tbbModeEcma.Text = "ECMA Script";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbllMatches,
            this.statusLblLastMatch,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1,
            this.statusLblInsMode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLbllMatches
            // 
            this.statusLbllMatches.AutoSize = false;
            this.statusLbllMatches.Name = "statusLbllMatches";
            this.statusLbllMatches.Size = new System.Drawing.Size(130, 17);
            this.statusLbllMatches.Text = "Matches: 0";
            this.statusLbllMatches.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLblLastMatch
            // 
            this.statusLblLastMatch.AutoSize = false;
            this.statusLblLastMatch.Name = "statusLblLastMatch";
            this.statusLblLastMatch.Size = new System.Drawing.Size(200, 17);
            this.statusLblLastMatch.Text = "Last Match:";
            this.statusLblLastMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(385, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // statusLblInsMode
            // 
            this.statusLblInsMode.AutoSize = false;
            this.statusLblInsMode.Name = "statusLblInsMode";
            this.statusLblInsMode.Size = new System.Drawing.Size(60, 17);
            this.statusLblInsMode.Text = "INS";
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.Location = new System.Drawing.Point(0, 49);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Size = new System.Drawing.Size(790, 529);
            this.dockPanel.TabIndex = 3;
            // 
            // mnuDocTabs
            // 
            this.mnuDocTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDocTabSave,
            this.mnuDocTabClose,
            this.toolStripMenuItem4,
            this.mnuDocTabOpenFolder});
            this.mnuDocTabs.Name = "mnuStripDocTabs";
            this.mnuDocTabs.Size = new System.Drawing.Size(202, 76);
            this.mnuDocTabs.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuStripDocTabs_ItemClicked);
            // 
            // mnuDocTabSave
            // 
            this.mnuDocTabSave.Name = "mnuDocTabSave";
            this.mnuDocTabSave.Size = new System.Drawing.Size(201, 22);
            this.mnuDocTabSave.Text = "Save";
            // 
            // mnuDocTabClose
            // 
            this.mnuDocTabClose.Name = "mnuDocTabClose";
            this.mnuDocTabClose.Size = new System.Drawing.Size(201, 22);
            this.mnuDocTabClose.Text = "Close";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 6);
            // 
            // mnuDocTabOpenFolder
            // 
            this.mnuDocTabOpenFolder.Name = "mnuDocTabOpenFolder";
            this.mnuDocTabOpenFolder.Size = new System.Drawing.Size(201, 22);
            this.mnuDocTabOpenFolder.Text = "Open Containing Folder";
            // 
            // animWidgetRotator1
            // 
            this.animWidgetRotator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animWidgetRotator1.BackgroundImageRotation = 0F;
            this.animWidgetRotator1.CalcPrecision = 3;
            this.animWidgetRotator1.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.animWidgetRotator1.ForeColor = System.Drawing.Color.SlateGray;
            this.animWidgetRotator1.HoleDiameter = 20;
            this.animWidgetRotator1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
            this.animWidgetRotator1.Location = new System.Drawing.Point(711, 52);
            this.animWidgetRotator1.MultiSample = true;
            this.animWidgetRotator1.Name = "animWidgetRotator1";
            this.animWidgetRotator1.PenWidth = 5;
            this.animWidgetRotator1.RefreshDelayMS = 60;
            this.animWidgetRotator1.Size = new System.Drawing.Size(67, 65);
            this.animWidgetRotator1.SliceCount = 5;
            this.animWidgetRotator1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.animWidgetRotator1.TabIndex = 6;
            this.animWidgetRotator1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 600);
            this.Controls.Add(this.animWidgetRotator1);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Rainstorm Studios RegEx Tester";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnuDocTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileRecent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePref;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mnuDocument;
        private System.Windows.Forms.ToolStripMenuItem mnuDocumentMatch;
        private System.Windows.Forms.ToolStripMenuItem mnuDocumentReplace;
        private System.Windows.Forms.ToolStripMenuItem mnuDocumentSplit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsCompileAsm;
        private System.Windows.Forms.ToolStripMenuItem mnuToolsGenCode;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpContents;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripButton tbbNew;
        private System.Windows.Forms.ToolStripButton tbbSave;
        private System.Windows.Forms.ToolStripButton tbbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbbMatch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbbModeIgnoreCase;
        private System.Windows.Forms.ToolStripButton tbbModeMultiline;
        private System.Windows.Forms.ToolStripButton tbbModeSingleLine;
        private System.Windows.Forms.ToolStripButton tbbModeIgnoreWhitespace;
        private System.Windows.Forms.ToolStripButton tbbModeRightToLeft;
        private System.Windows.Forms.ToolStripButton tbbModeExplicitCapture;
        private System.Windows.Forms.ToolStripButton tbbModeEcma;
        private RainstormStudios.Controls.AnimWidgetRotator animWidgetRotator1;
        private System.Windows.Forms.ToolStripStatusLabel statusLbllMatches;
        private System.Windows.Forms.ToolStripStatusLabel statusLblLastMatch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
#if DEBUG
        private System.Windows.Forms.ToolStripMenuItem mnuDebug;
        private System.Windows.Forms.ToolStripMenuItem mnuDebugSaveLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuDebugClearLayout;
#endif

        private System.Windows.Forms.ToolStripMenuItem mnuDocTabSave;
        private System.Windows.Forms.ToolStripMenuItem mnuDocTabClose;
        private System.Windows.Forms.ToolStripMenuItem mnuDocTabOpenFolder;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLayoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem clearUserLayoutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mnuDocTabs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripStatusLabel statusLblInsMode;
        private System.Windows.Forms.ToolStripButton tbbReplace;
        private System.Windows.Forms.ToolStripButton tbbSplit;
    }
}

