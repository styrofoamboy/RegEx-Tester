namespace RegexTester
{
    partial class frmCompileAsm
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath3 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath4 = new System.Drawing.Drawing2D.GraphicsPath();
            this.grpAsmDetails = new System.Windows.Forms.GroupBox();
            this.chkAllDocs = new System.Windows.Forms.CheckBox();
            this.drpAsmScope = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsmClass = new System.Windows.Forms.TextBox();
            this.txtAsmNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new RainstormStudios.Controls.AdvancedButton();
            this.btnCompile = new RainstormStudios.Controls.AdvancedButton();
            this.fsbOutputAsm = new RainstormStudios.Controls.FileSelectBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAsmDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAsmDetails
            // 
            this.grpAsmDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAsmDetails.Controls.Add(this.chkAllDocs);
            this.grpAsmDetails.Controls.Add(this.drpAsmScope);
            this.grpAsmDetails.Controls.Add(this.label3);
            this.grpAsmDetails.Controls.Add(this.label2);
            this.grpAsmDetails.Controls.Add(this.txtAsmClass);
            this.grpAsmDetails.Controls.Add(this.txtAsmNamespace);
            this.grpAsmDetails.Controls.Add(this.label1);
            this.grpAsmDetails.Location = new System.Drawing.Point(12, 71);
            this.grpAsmDetails.Name = "grpAsmDetails";
            this.grpAsmDetails.Size = new System.Drawing.Size(415, 116);
            this.grpAsmDetails.TabIndex = 1;
            this.grpAsmDetails.TabStop = false;
            this.grpAsmDetails.Text = "Assembly Details";
            // 
            // chkAllDocs
            // 
            this.chkAllDocs.AutoSize = true;
            this.chkAllDocs.Checked = true;
            this.chkAllDocs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllDocs.Location = new System.Drawing.Point(272, 80);
            this.chkAllDocs.Name = "chkAllDocs";
            this.chkAllDocs.Size = new System.Drawing.Size(123, 17);
            this.chkAllDocs.TabIndex = 7;
            this.chkAllDocs.Text = "All Open Documents";
            this.chkAllDocs.UseVisualStyleBackColor = true;
            this.chkAllDocs.CheckedChanged += new System.EventHandler(this.chkAllDocs_CheckedChanged);
            // 
            // drpAsmScope
            // 
            this.drpAsmScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpAsmScope.FormattingEnabled = true;
            this.drpAsmScope.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.drpAsmScope.Location = new System.Drawing.Point(110, 78);
            this.drpAsmScope.Name = "drpAsmScope";
            this.drpAsmScope.Size = new System.Drawing.Size(145, 21);
            this.drpAsmScope.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Protection:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class:";
            // 
            // txtAsmClass
            // 
            this.txtAsmClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsmClass.Enabled = false;
            this.txtAsmClass.Location = new System.Drawing.Point(110, 52);
            this.txtAsmClass.Name = "txtAsmClass";
            this.txtAsmClass.Size = new System.Drawing.Size(285, 20);
            this.txtAsmClass.TabIndex = 2;
            this.txtAsmClass.Text = "MyRegexClass";
            // 
            // txtAsmNamespace
            // 
            this.txtAsmNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsmNamespace.Location = new System.Drawing.Point(110, 26);
            this.txtAsmNamespace.Name = "txtAsmNamespace";
            this.txtAsmNamespace.Size = new System.Drawing.Size(285, 20);
            this.txtAsmNamespace.TabIndex = 1;
            this.txtAsmNamespace.Text = "MyRegexNamepsace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namespace:";
            // 
            // btnCancel
            // 
            this.btnCancel.AllowWordWrap = false;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.btnCancel.BackgroundRotationDegrees = 0F;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnCancel.BorderWidth = 1;
            graphicsPath3.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnCancel.ButtonShape = graphicsPath3;
            this.btnCancel.CornerFeather = 5;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnCancel.HighlightMultiplier = 2F;
            this.btnCancel.HoverHighlightColor = System.Drawing.Color.IndianRed;
            this.btnCancel.HoverHighlightOpacity = 200;
            this.btnCancel.HoverImage = null;
            this.btnCancel.ImagePadding = 0;
            this.btnCancel.Location = new System.Drawing.Point(352, 197);
            this.btnCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnCancel.MouseDownImage = null;
            this.btnCancel.MultiSample = true;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextOutline = false;
            this.btnCancel.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnCancel.TextOutlineOpacity = 255;
            this.btnCancel.TextOutlineWeight = 2F;
            this.btnCancel.TextRotationDegrees = 0F;
            this.btnCancel.TextShadow = false;
            this.btnCancel.TextShadowOffset = 1F;
            this.btnCancel.TextShadowOpacity = 80;
            this.btnCancel.TextVeritcal = false;
            this.btnCancel.ThreeDEffectDepth = 50;
            this.btnCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCompile
            // 
            this.btnCompile.AllowWordWrap = false;
            this.btnCompile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.btnCompile.BackgroundRotationDegrees = 0F;
            this.btnCompile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnCompile.BorderWidth = 1;
            graphicsPath4.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnCompile.ButtonShape = graphicsPath4;
            this.btnCompile.CornerFeather = 5;
            this.btnCompile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCompile.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompile.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCompile.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnCompile.HighlightMultiplier = 2F;
            this.btnCompile.HoverHighlightColor = System.Drawing.Color.Orange;
            this.btnCompile.HoverHighlightOpacity = 200;
            this.btnCompile.HoverImage = null;
            this.btnCompile.ImagePadding = 0;
            this.btnCompile.Location = new System.Drawing.Point(212, 197);
            this.btnCompile.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnCompile.MouseDownImage = null;
            this.btnCompile.MultiSample = true;
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(120, 23);
            this.btnCompile.TabIndex = 3;
            this.btnCompile.Text = "Compile Assembly";
            this.btnCompile.TextOutline = false;
            this.btnCompile.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnCompile.TextOutlineOpacity = 255;
            this.btnCompile.TextOutlineWeight = 2F;
            this.btnCompile.TextRotationDegrees = 0F;
            this.btnCompile.TextShadow = false;
            this.btnCompile.TextShadowOffset = 1F;
            this.btnCompile.TextShadowOpacity = 80;
            this.btnCompile.TextVeritcal = false;
            this.btnCompile.ThreeDEffectDepth = 50;
            this.btnCompile.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnCompile.UseVisualStyleBackColor = true;
            // 
            // fsbOutputAsm
            // 
            this.fsbOutputAsm.AddExtension = false;
            this.fsbOutputAsm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fsbOutputAsm.CheckFileExists = false;
            this.fsbOutputAsm.ControlTitle = "Assembly File Name";
            this.fsbOutputAsm.DefaultExtension = ".dll";
            this.fsbOutputAsm.DialogFilter = "Libraries|*.dll|All Files|*.*";
            this.fsbOutputAsm.DialogFilterIndex = 0;
            this.fsbOutputAsm.DialogTitle = "Select Compiled Assembly File";
            this.fsbOutputAsm.FileName = "";
            this.fsbOutputAsm.FileNames = new string[0];
            this.fsbOutputAsm.FileSelectType = RainstormStudios.Controls.FileDialogType.Save;
            this.fsbOutputAsm.GlobalBackgroundColor = System.Drawing.SystemColors.Window;
            this.fsbOutputAsm.GlobalFlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fsbOutputAsm.GlobalForegroundColor = System.Drawing.SystemColors.WindowText;
            this.fsbOutputAsm.InitialDirectory = "";
            this.fsbOutputAsm.Location = new System.Drawing.Point(12, 12);
            this.fsbOutputAsm.MinimumSize = new System.Drawing.Size(280, 40);
            this.fsbOutputAsm.Name = "fsbOutputAsm";
            this.fsbOutputAsm.RestoreDirectory = false;
            this.fsbOutputAsm.Size = new System.Drawing.Size(415, 40);
            this.fsbOutputAsm.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOTE: Unsaved documents will not be included in the assembly.";
            // 
            // frmCompileAsm
            // 
            this.AcceptButton = this.btnCompile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(439, 232);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fsbOutputAsm);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpAsmDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCompileAsm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compile to Assembly";
            this.grpAsmDetails.ResumeLayout(false);
            this.grpAsmDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAsmDetails;
        private System.Windows.Forms.TextBox txtAsmClass;
        private System.Windows.Forms.TextBox txtAsmNamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpAsmScope;
        private RainstormStudios.Controls.AdvancedButton btnCancel;
        private RainstormStudios.Controls.AdvancedButton btnCompile;
        private RainstormStudios.Controls.FileSelectBox fsbOutputAsm;
        private System.Windows.Forms.CheckBox chkAllDocs;
        private System.Windows.Forms.Label label4;
    }
}