namespace RegexTester
{
    partial class frmRgxDoc
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
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rgxTextBox = new RegexTester.ctrlRegExTextBox();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.toolStripSeparator1,
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDelete,
            this.toolStripMenuItem1,
            this.mnuSelectAll});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(129, 148);
            this.contextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenu_ItemClicked);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(128, 22);
            this.mnuCut.Text = "Cut";
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(128, 22);
            this.mnuCopy.Text = "Copy";
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(128, 22);
            this.mnuPaste.Text = "Paste";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(128, 22);
            this.mnuDelete.Text = "Delete";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 6);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.Size = new System.Drawing.Size(128, 22);
            this.mnuSelectAll.Text = "Select All";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.Size = new System.Drawing.Size(128, 22);
            this.mnuUndo.Text = "Undo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // rgxTextBox
            // 
            this.rgxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rgxTextBox.ContextMenuStrip = this.contextMenu;
            this.rgxTextBox.DetectUrls = false;
            this.rgxTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgxTextBox.HideCaretWhenReadOnly = false;
            this.rgxTextBox.HorizontalScrollPos = 0;
            this.rgxTextBox.IsInsertMode = false;
            this.rgxTextBox.Location = new System.Drawing.Point(0, 0);
            this.rgxTextBox.MaxUndoLevel = 100;
            this.rgxTextBox.Name = "rgxTextBox";
            this.rgxTextBox.ShortcutsEnabled = false;
            this.rgxTextBox.Size = new System.Drawing.Size(486, 357);
            this.rgxTextBox.TabIndex = 1;
            this.rgxTextBox.Text = "";
            this.rgxTextBox.VerticalScrollPos = 0;
            this.rgxTextBox.WordWrap = false;
            this.rgxTextBox.InsertModeChanged += new System.EventHandler(this.rgxTextBox_InsertModeChanged);
            this.rgxTextBox.TextChanged += new System.EventHandler(this.rgxTextBox_TextChanged);
            // 
            // frmRgxDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 357);
            this.Controls.Add(this.rgxTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRgxDoc";
            this.Text = "frmRgxDoc";
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private ctrlRegExTextBox rgxTextBox;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

    }
}