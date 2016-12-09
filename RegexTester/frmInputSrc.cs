using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RegexTester
{
    public partial class frmInputSrc : DockContent
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private string
            _srcFn;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string InputText
        {
            get { return this.rtfInputSrc.Text; }
            set { this.rtfInputSrc.Text = value; }
        }
        public string[] InputLines
        {
            get { return this.rtfInputSrc.Lines; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmInputSrc()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void Highlight(int start, int length, Color clr)
        {
            try
            { this.rtfInputSrc.Select(start, length); }
            catch (Exception)
            { }
        }
        public void ClearHighlight()
        {
            this.rtfInputSrc.Select(0, 0);
        }
        #endregion

        #region Non-Public Methods
        //***************************************************************************
        // Private Methods
        // 
        private void OpenFile()
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Source Text File";
                dlg.Multiselect = false;
                dlg.Filter = "Text Files|*.txt;*.xml;*.doc;*.rtf|All Files|*.*";
                dlg.FilterIndex = 0;
                dlg.SupportMultiDottedExtensions = true;
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    this._srcFn = dlg.FileName;
                    this.txtOpenFile.Text = Path.GetFileName(this._srcFn);
                    this.ReadFile();
                }
            }
        }
        private void ReadFile()
        {
            this.btnRefreshDoc.Enabled = false;
            if (string.IsNullOrEmpty(this._srcFn) || !File.Exists(this._srcFn))
                return;

            this.rtfInputSrc.Clear();
            if (!RainstormStudios.rsString.EqualToAny(Path.GetExtension(this._srcFn).ToLower(), ".rtf", ".doc"))
            {
                using (FileStream fs = new FileStream(this._srcFn, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                    while (!sr.EndOfStream)
                        this.rtfInputSrc.AppendText(sr.ReadLine() + "\n");
            }
            else
                this.rtfInputSrc.LoadFile(this._srcFn, RichTextBoxStreamType.RichText);

            this.btnRefreshDoc.Enabled = true;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void btnOpenFile(object sender, EventArgs e)
        {
            this.OpenFile();
        }
        private void btnReadFile(object sender, EventArgs e)
        {
            this.ReadFile();
        }
        private void mnuRtf_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuRtfCut":
                    this.rtfInputSrc.Cut();
                    break;
                case "mnuRtfCopy":
                    this.rtfInputSrc.Copy();
                    break;
                case "mnuRtfPaste":
                    this.rtfInputSrc.Paste();
                    break;
                case "mnuRtfDelete":
                    this.rtfInputSrc.SelectedText = "";
                    break;
                case "mnuRtfSelAll":
                    this.rtfInputSrc.SelectAll();
                    break;
                case "mnuRtfClear":
                    this.rtfInputSrc.Clear();
                    break;
            }
        }
        private void btnWrapText_Click(object sender, EventArgs e)
        {
            this.rtfInputSrc.WordWrap = (!this.rtfInputSrc.WordWrap);
        }
        #endregion

    }
}
