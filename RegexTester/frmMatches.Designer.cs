namespace RegexTester
{
    partial class frmMatches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatches));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbExportList = new System.Windows.Forms.ToolStripButton();
            this.trvMatches = new System.Windows.Forms.TreeView();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMnuExportResults = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "package_go.png");
            this.imageList1.Images.SetKeyName(1, "note.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExportList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(310, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbExportList
            // 
            this.tsbExportList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExportList.Image = global::RegexTester.Properties.Resources.page_save;
            this.tsbExportList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExportList.Name = "tsbExportList";
            this.tsbExportList.Size = new System.Drawing.Size(23, 22);
            this.tsbExportList.Text = "Export Lists";
            // 
            // trvMatches
            // 
            this.trvMatches.ContextMenuStrip = this.ctxMenu;
            this.trvMatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMatches.ImageIndex = 0;
            this.trvMatches.ImageList = this.imageList1;
            this.trvMatches.Location = new System.Drawing.Point(0, 25);
            this.trvMatches.Name = "trvMatches";
            this.trvMatches.SelectedImageIndex = 0;
            this.trvMatches.Size = new System.Drawing.Size(310, 388);
            this.trvMatches.TabIndex = 3;
            this.trvMatches.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMatches_AfterSelect);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMnuExportResults});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(153, 48);
            this.ctxMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxMenu_ItemClicked);
            // 
            // ctxMnuExportResults
            // 
            this.ctxMnuExportResults.Name = "ctxMnuExportResults";
            this.ctxMnuExportResults.Size = new System.Drawing.Size(152, 22);
            this.ctxMnuExportResults.Text = "Export Results";
            // 
            // frmMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 413);
            this.Controls.Add(this.trvMatches);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMatches";
            this.TabText = "frmMatches";
            this.Text = "frmMatches";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView trvMatches;
        private System.Windows.Forms.ToolStripButton tsbExportList;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxMnuExportResults;
    }
}