namespace RegexTester
{
    partial class frmExportMatchList
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath9 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath10 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath11 = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath graphicsPath12 = new System.Drawing.Drawing2D.GraphicsPath();
            this.cmdCancel = new RainstormStudios.Controls.AdvancedButton();
            this.cmdSave = new RainstormStudios.Controls.AdvancedButton();
            this.threeDLine1 = new RainstormStudios.Controls.ThreeDLine();
            this.lstGroupNames = new System.Windows.Forms.CheckedListBox();
            this.chkUseMaster = new System.Windows.Forms.CheckBox();
            this.chkUseGroups = new System.Windows.Forms.CheckBox();
            this.cmdAll = new RainstormStudios.Controls.AdvancedButton();
            this.cmdNone = new RainstormStudios.Controls.AdvancedButton();
            this.panMatchGroups = new System.Windows.Forms.Panel();
            this.grpExportIncludes = new System.Windows.Forms.GroupBox();
            this.grpOutputMode = new System.Windows.Forms.GroupBox();
            this.rdoModeSepList = new System.Windows.Forms.RadioButton();
            this.rdoModeNested = new System.Windows.Forms.RadioButton();
            this.panMatchGroups.SuspendLayout();
            this.grpExportIncludes.SuspendLayout();
            this.grpOutputMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdCancel.BorderWidth = 1;
            graphicsPath9.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdCancel.ButtonShape = graphicsPath9;
            this.cmdCancel.CornerFeather = 5;
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdCancel.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdCancel.HighlightMultiplier = 2F;
            this.cmdCancel.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdCancel.HoverHighlightOpacity = 200;
            this.cmdCancel.HoverImage = null;
            this.cmdCancel.ImagePadding = 0;
            this.cmdCancel.Location = new System.Drawing.Point(435, 249);
            this.cmdCancel.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdCancel.MouseDownImage = null;
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 0;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.TextOutline = false;
            this.cmdCancel.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdCancel.TextOutlineOpacity = 255;
            this.cmdCancel.TextOutlineWeight = 2F;
            this.cmdCancel.ThreeDEffectDepth = 50;
            this.cmdCancel.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdSave.BorderWidth = 1;
            graphicsPath10.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdSave.ButtonShape = graphicsPath10;
            this.cmdSave.CornerFeather = 5;
            this.cmdSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdSave.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdSave.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdSave.HighlightMultiplier = 2F;
            this.cmdSave.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdSave.HoverHighlightOpacity = 200;
            this.cmdSave.HoverImage = null;
            this.cmdSave.ImagePadding = 0;
            this.cmdSave.Location = new System.Drawing.Point(354, 249);
            this.cmdSave.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdSave.MouseDownImage = null;
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextOutline = false;
            this.cmdSave.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdSave.TextOutlineOpacity = 255;
            this.cmdSave.TextOutlineWeight = 2F;
            this.cmdSave.ThreeDEffectDepth = 50;
            this.cmdSave.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdSave.UseVisualStyleBackColor = true;
            // 
            // threeDLine1
            // 
            this.threeDLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeDLine1.Location = new System.Drawing.Point(12, 231);
            this.threeDLine1.MaximumSize = new System.Drawing.Size(0, 0);
            this.threeDLine1.MinimumSize = new System.Drawing.Size(0, 0);
            this.threeDLine1.Name = "threeDLine1";
            this.threeDLine1.Size = new System.Drawing.Size(498, 12);
            this.threeDLine1.TabIndex = 2;
            this.threeDLine1.Text = "threeDLine1";
            // 
            // lstGroupNames
            // 
            this.lstGroupNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGroupNames.CheckOnClick = true;
            this.lstGroupNames.FormattingEnabled = true;
            this.lstGroupNames.IntegralHeight = false;
            this.lstGroupNames.Location = new System.Drawing.Point(0, 0);
            this.lstGroupNames.Name = "lstGroupNames";
            this.lstGroupNames.Size = new System.Drawing.Size(274, 184);
            this.lstGroupNames.TabIndex = 3;
            // 
            // chkUseMaster
            // 
            this.chkUseMaster.AutoSize = true;
            this.chkUseMaster.Checked = true;
            this.chkUseMaster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseMaster.Location = new System.Drawing.Point(6, 19);
            this.chkUseMaster.Name = "chkUseMaster";
            this.chkUseMaster.Size = new System.Drawing.Size(105, 17);
            this.chkUseMaster.TabIndex = 4;
            this.chkUseMaster.Text = "Master match list";
            this.chkUseMaster.UseVisualStyleBackColor = true;
            // 
            // chkUseGroups
            // 
            this.chkUseGroups.AutoSize = true;
            this.chkUseGroups.Checked = true;
            this.chkUseGroups.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseGroups.Location = new System.Drawing.Point(6, 42);
            this.chkUseGroups.Name = "chkUseGroups";
            this.chkUseGroups.Size = new System.Drawing.Size(123, 17);
            this.chkUseGroups.TabIndex = 5;
            this.chkUseGroups.Text = "Selected sub-groups";
            this.chkUseGroups.UseVisualStyleBackColor = true;
            this.chkUseGroups.CheckedChanged += new System.EventHandler(this.chkUseGroups_CheckedChanged);
            // 
            // cmdAll
            // 
            this.cmdAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdAll.BorderWidth = 1;
            graphicsPath11.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdAll.ButtonShape = graphicsPath11;
            this.cmdAll.CornerFeather = 1;
            this.cmdAll.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdAll.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdAll.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdAll.HighlightMultiplier = 2F;
            this.cmdAll.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdAll.HoverHighlightOpacity = 200;
            this.cmdAll.HoverImage = null;
            this.cmdAll.ImagePadding = 0;
            this.cmdAll.Location = new System.Drawing.Point(145, 188);
            this.cmdAll.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdAll.MouseDownImage = null;
            this.cmdAll.Name = "cmdAll";
            this.cmdAll.Size = new System.Drawing.Size(60, 20);
            this.cmdAll.TabIndex = 8;
            this.cmdAll.Text = "All";
            this.cmdAll.TextOutline = false;
            this.cmdAll.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdAll.TextOutlineOpacity = 255;
            this.cmdAll.TextOutlineWeight = 2F;
            this.cmdAll.ThreeDEffectDepth = 50;
            this.cmdAll.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdAll.UseVisualStyleBackColor = true;
            this.cmdAll.Click += new System.EventHandler(this.cmdAll_Click);
            // 
            // cmdNone
            // 
            this.cmdNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.cmdNone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.cmdNone.BorderWidth = 1;
            graphicsPath12.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.cmdNone.ButtonShape = graphicsPath12;
            this.cmdNone.CornerFeather = 1;
            this.cmdNone.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdNone.DisabledForeColor = System.Drawing.Color.Gray;
            this.cmdNone.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.cmdNone.HighlightMultiplier = 2F;
            this.cmdNone.HoverHighlightColor = System.Drawing.Color.Orange;
            this.cmdNone.HoverHighlightOpacity = 200;
            this.cmdNone.HoverImage = null;
            this.cmdNone.ImagePadding = 0;
            this.cmdNone.Location = new System.Drawing.Point(211, 188);
            this.cmdNone.MinimumSize = new System.Drawing.Size(8, 8);
            this.cmdNone.MouseDownImage = null;
            this.cmdNone.Name = "cmdNone";
            this.cmdNone.Size = new System.Drawing.Size(60, 20);
            this.cmdNone.TabIndex = 9;
            this.cmdNone.Text = "None";
            this.cmdNone.TextOutline = false;
            this.cmdNone.TextOutlineColor = System.Drawing.Color.Empty;
            this.cmdNone.TextOutlineOpacity = 255;
            this.cmdNone.TextOutlineWeight = 2F;
            this.cmdNone.ThreeDEffectDepth = 50;
            this.cmdNone.ToggleActiveColor = System.Drawing.Color.Empty;
            this.cmdNone.UseVisualStyleBackColor = true;
            this.cmdNone.Click += new System.EventHandler(this.cmdNone_Click);
            // 
            // panMatchGroups
            // 
            this.panMatchGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMatchGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMatchGroups.Controls.Add(this.lstGroupNames);
            this.panMatchGroups.Controls.Add(this.cmdNone);
            this.panMatchGroups.Controls.Add(this.cmdAll);
            this.panMatchGroups.Location = new System.Drawing.Point(234, 12);
            this.panMatchGroups.Name = "panMatchGroups";
            this.panMatchGroups.Size = new System.Drawing.Size(276, 213);
            this.panMatchGroups.TabIndex = 10;
            // 
            // grpExportIncludes
            // 
            this.grpExportIncludes.Controls.Add(this.chkUseMaster);
            this.grpExportIncludes.Controls.Add(this.chkUseGroups);
            this.grpExportIncludes.Location = new System.Drawing.Point(12, 12);
            this.grpExportIncludes.Name = "grpExportIncludes";
            this.grpExportIncludes.Size = new System.Drawing.Size(216, 70);
            this.grpExportIncludes.TabIndex = 11;
            this.grpExportIncludes.TabStop = false;
            this.grpExportIncludes.Text = "Included in Output";
            // 
            // grpOutputMode
            // 
            this.grpOutputMode.Controls.Add(this.rdoModeNested);
            this.grpOutputMode.Controls.Add(this.rdoModeSepList);
            this.grpOutputMode.Location = new System.Drawing.Point(12, 88);
            this.grpOutputMode.Name = "grpOutputMode";
            this.grpOutputMode.Size = new System.Drawing.Size(216, 69);
            this.grpOutputMode.TabIndex = 12;
            this.grpOutputMode.TabStop = false;
            this.grpOutputMode.Text = "Output Mode";
            // 
            // rdoModeSepList
            // 
            this.rdoModeSepList.AutoSize = true;
            this.rdoModeSepList.Location = new System.Drawing.Point(6, 42);
            this.rdoModeSepList.Name = "rdoModeSepList";
            this.rdoModeSepList.Size = new System.Drawing.Size(92, 17);
            this.rdoModeSepList.TabIndex = 13;
            this.rdoModeSepList.Text = "Separate Lists";
            this.rdoModeSepList.UseVisualStyleBackColor = true;
            // 
            // rdoModeNested
            // 
            this.rdoModeNested.AutoSize = true;
            this.rdoModeNested.Checked = true;
            this.rdoModeNested.Location = new System.Drawing.Point(6, 19);
            this.rdoModeNested.Name = "rdoModeNested";
            this.rdoModeNested.Size = new System.Drawing.Size(103, 17);
            this.rdoModeNested.TabIndex = 14;
            this.rdoModeNested.TabStop = true;
            this.rdoModeNested.Text = "Nested Sections";
            this.rdoModeNested.UseVisualStyleBackColor = true;
            // 
            // frmExportMatchList
            // 
            this.AcceptButton = this.cmdSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(522, 284);
            this.Controls.Add(this.grpOutputMode);
            this.Controls.Add(this.grpExportIncludes);
            this.Controls.Add(this.panMatchGroups);
            this.Controls.Add(this.threeDLine1);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExportMatchList";
            this.ShowInTaskbar = false;
            this.Text = "Export Match List";
            this.panMatchGroups.ResumeLayout(false);
            this.grpExportIncludes.ResumeLayout(false);
            this.grpExportIncludes.PerformLayout();
            this.grpOutputMode.ResumeLayout(false);
            this.grpOutputMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RainstormStudios.Controls.AdvancedButton cmdCancel;
        private RainstormStudios.Controls.AdvancedButton cmdSave;
        private RainstormStudios.Controls.ThreeDLine threeDLine1;
        private System.Windows.Forms.CheckedListBox lstGroupNames;
        private System.Windows.Forms.CheckBox chkUseMaster;
        private System.Windows.Forms.CheckBox chkUseGroups;
        private RainstormStudios.Controls.AdvancedButton cmdAll;
        private RainstormStudios.Controls.AdvancedButton cmdNone;
        private System.Windows.Forms.Panel panMatchGroups;
        private System.Windows.Forms.GroupBox grpExportIncludes;
        private System.Windows.Forms.GroupBox grpOutputMode;
        private System.Windows.Forms.RadioButton rdoModeNested;
        private System.Windows.Forms.RadioButton rdoModeSepList;


    }
}