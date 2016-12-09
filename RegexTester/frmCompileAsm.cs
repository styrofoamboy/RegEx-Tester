using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegexTester
{
    public partial class frmCompileAsm : Form
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public string ClassName
        {
            get { return this.txtAsmClass.Text; }
        }
        public string NamespaceName
        {
            get { return this.txtAsmNamespace.Text; }
        }
        public string AssemblyName
        {
            get { return this.fsbOutputAsm.FileName; }
        }
        public string ProtectionLevel
        {
            get { return this.drpAsmScope.Text; }
        }
        public bool AllActiveDocs
        {
            get { return this.chkAllDocs.Checked; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmCompileAsm()
        {
            InitializeComponent();
            this.drpAsmScope.SelectedIndex = 0;
        }
        public frmCompileAsm(string nmspc, string classNm, string asmNm)
            : this()
        {
            if (!string.IsNullOrEmpty(asmNm))
                this.fsbOutputAsm.FileName = asmNm + ".dll";
            if (!string.IsNullOrEmpty(nmspc))
                this.txtAsmNamespace.Text = nmspc;
            if (!string.IsNullOrEmpty(classNm))
                this.txtAsmClass.Text = classNm;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void chkAllDocs_CheckedChanged(object sender, EventArgs e)
        {
            this.txtAsmClass.Enabled = (!this.chkAllDocs.Checked);
        }
        #endregion
    }
}
