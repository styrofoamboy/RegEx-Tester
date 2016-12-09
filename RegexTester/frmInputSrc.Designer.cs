namespace RegexTester
{
    partial class frmInputSrc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWrapText = new System.Windows.Forms.Button();
            this.btnRefreshDoc = new System.Windows.Forms.Button();
            this.btnOpenDoc = new System.Windows.Forms.Button();
            this.txtOpenFile = new System.Windows.Forms.TextBox();
            this.rtfInputSrc = new RainstormStudios.Controls.AdvRichTextBox();
            this.mnuRtf = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRtfCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRtfCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRtfPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRtfDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRtfSelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRtfClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.mnuRtf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnWrapText);
            this.panel1.Controls.Add(this.btnRefreshDoc);
            this.panel1.Controls.Add(this.btnOpenDoc);
            this.panel1.Controls.Add(this.txtOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 26);
            this.panel1.TabIndex = 0;
            // 
            // btnWrapText
            // 
            this.btnWrapText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrapText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrapText.Image = global::RegexTester.Properties.Resources.page_white_text1;
            this.btnWrapText.Location = new System.Drawing.Point(544, 1);
            this.btnWrapText.Name = "btnWrapText";
            this.btnWrapText.Size = new System.Drawing.Size(31, 23);
            this.btnWrapText.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnWrapText, "Toggle Wrap Text");
            this.btnWrapText.UseVisualStyleBackColor = true;
            this.btnWrapText.Click += new System.EventHandler(this.btnWrapText_Click);
            // 
            // btnRefreshDoc
            // 
            this.btnRefreshDoc.Enabled = false;
            this.btnRefreshDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDoc.Image = global::RegexTester.Properties.Resources.action_refresh;
            this.btnRefreshDoc.Location = new System.Drawing.Point(295, 0);
            this.btnRefreshDoc.Name = "btnRefreshDoc";
            this.btnRefreshDoc.Size = new System.Drawing.Size(31, 23);
            this.btnRefreshDoc.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnRefreshDoc, "Refresh From Source File");
            this.btnRefreshDoc.UseVisualStyleBackColor = true;
            this.btnRefreshDoc.Click += new System.EventHandler(this.btnReadFile);
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDoc.Image = global::RegexTester.Properties.Resources.folder_page;
            this.btnOpenDoc.Location = new System.Drawing.Point(258, 0);
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Size = new System.Drawing.Size(31, 23);
            this.btnOpenDoc.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnOpenDoc, "Load Source Document");
            this.btnOpenDoc.UseVisualStyleBackColor = true;
            this.btnOpenDoc.Click += new System.EventHandler(this.btnOpenFile);
            // 
            // txtOpenFile
            // 
            this.txtOpenFile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOpenFile.Location = new System.Drawing.Point(3, 3);
            this.txtOpenFile.Name = "txtOpenFile";
            this.txtOpenFile.ReadOnly = true;
            this.txtOpenFile.Size = new System.Drawing.Size(249, 20);
            this.txtOpenFile.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtOpenFile, "Source File Name");
            // 
            // rtfInputSrc
            // 
            this.rtfInputSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfInputSrc.BackColor = System.Drawing.SystemColors.Window;
            this.rtfInputSrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfInputSrc.ContextMenuStrip = this.mnuRtf;
            this.rtfInputSrc.DetectUrls = false;
            this.rtfInputSrc.EnableAutoDragDrop = true;
            this.rtfInputSrc.HideCaretWhenReadOnly = true;
            this.rtfInputSrc.HideSelection = false;
            this.rtfInputSrc.HorizontalScrollPos = 0;
            this.rtfInputSrc.Location = new System.Drawing.Point(0, 26);
            this.rtfInputSrc.MaxUndoLevel = 100;
            this.rtfInputSrc.Name = "rtfInputSrc";
            this.rtfInputSrc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtfInputSrc.Size = new System.Drawing.Size(587, 442);
            this.rtfInputSrc.TabIndex = 1;
            this.rtfInputSrc.Text = "";
            this.rtfInputSrc.VerticalScrollPos = 0;
            this.rtfInputSrc.WordWrap = false;
            // 
            // mnuRtf
            // 
            this.mnuRtf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRtfCut,
            this.mnuRtfCopy,
            this.mnuRtfPaste,
            this.mnuRtfDelete,
            this.toolStripMenuItem1,
            this.mnuRtfSelAll,
            this.mnuRtfClear});
            this.mnuRtf.Name = "mnuRtf";
            this.mnuRtf.Size = new System.Drawing.Size(123, 142);
            this.mnuRtf.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuRtf_ItemClicked);
            // 
            // mnuRtfCut
            // 
            this.mnuRtfCut.Name = "mnuRtfCut";
            this.mnuRtfCut.Size = new System.Drawing.Size(122, 22);
            this.mnuRtfCut.Text = "Cut";
            // 
            // mnuRtfCopy
            // 
            this.mnuRtfCopy.Name = "mnuRtfCopy";
            this.mnuRtfCopy.Size = new System.Drawing.Size(122, 22);
            this.mnuRtfCopy.Text = "Copy";
            // 
            // mnuRtfPaste
            // 
            this.mnuRtfPaste.Name = "mnuRtfPaste";
            this.mnuRtfPaste.Size = new System.Drawing.Size(122, 22);
            this.mnuRtfPaste.Text = "Paste";
            // 
            // mnuRtfDelete
            // 
            this.mnuRtfDelete.Name = "mnuRtfDelete";
            this.mnuRtfDelete.Size = new System.Drawing.Size(122, 22);
            this.mnuRtfDelete.Text = "Delete";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // mnuRtfSelAll
            // 
            this.mnuRtfSelAll.Name = "mnuRtfSelAll";
            this.mnuRtfSelAll.Size = new System.Drawing.Size(122, 22);
            this.mnuRtfSelAll.Text = "Select All";
            // 
            // mnuRtfClear
            // 
            this.mnuRtfClear.Name = "mnuRtfClear";
            this.mnuRtfClear.Size = new System.Drawing.Size(122, 22);
            this.mnuRtfClear.Text = "Clear";
            // 
            // frmInputSrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 468);
            this.Controls.Add(this.rtfInputSrc);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmInputSrc";
            this.Text = "frmInputSrc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnuRtf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RainstormStudios.Controls.AdvRichTextBox rtfInputSrc;
        private System.Windows.Forms.Button btnOpenDoc;
        private System.Windows.Forms.TextBox txtOpenFile;
        private System.Windows.Forms.Button btnRefreshDoc;
        private System.Windows.Forms.ContextMenuStrip mnuRtf;
        private System.Windows.Forms.ToolStripMenuItem mnuRtfCut;
        private System.Windows.Forms.ToolStripMenuItem mnuRtfCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuRtfPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuRtfDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuRtfSelAll;
        private System.Windows.Forms.ToolStripMenuItem mnuRtfClear;
        private System.Windows.Forms.Button btnWrapText;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}