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
    public partial class frmExportMatchList : Form
    {
        #region Nested Types
        //***************************************************************************
        // Nested Enums
        // 
        public enum ExportMode : uint
        {
            NestedList = 0,
            SeparatedLists
        }
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public bool IncludeMaster
        {
            get { return this.chkUseMaster.Checked; }
            set { this.chkUseMaster.Checked = value; }
        }
        public bool IncludeGroups
        {
            get { return this.chkUseGroups.Checked; }
            set { this.chkUseGroups.Checked = value; }
        }
        public List<string> IncludedGroupNames
        {
            get
            {
                List<string> grp = new List<string>(this.lstGroupNames.CheckedIndices.Count);
                for (int i = 0; i < this.lstGroupNames.CheckedIndices.Count; i++)
                    grp.Add(this.lstGroupNames.Items[this.lstGroupNames.CheckedIndices[i]].ToString());
                return grp;
            }
        }
        public ExportMode Mode
        {
            get
            {
                return 
                    this.rdoModeNested.Checked 
                        ? ExportMode.NestedList 
                        : ExportMode.SeparatedLists;
            }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        private frmExportMatchList()
        {
            InitializeComponent();
        }
        public frmExportMatchList(string[] groupNames)
            : this()
        {
            this.lstGroupNames.BeginUpdate();
            try
            {
                this.lstGroupNames.Items.Clear();
                for (int i = 0; i < groupNames.Length; i++)
                    this.lstGroupNames.Items.Add(groupNames[i]);
            }
            finally
            {
                this.lstGroupNames.EndUpdate();
            }
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void SetAllItemChecks(bool check)
        {
            for (int i = 0; i < this.lstGroupNames.Items.Count; i++)
                this.lstGroupNames.SetItemChecked(i, check);
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void cmdNone_Click(object sender, EventArgs e)
        {
            this.SetAllItemChecks(false);
        }
        private void cmdAll_Click(object sender, EventArgs e)
        {
            this.SetAllItemChecks(true);
        }
        private void chkUseGroups_CheckedChanged(object sender, EventArgs e)
        {
            this.panMatchGroups.Enabled = this.chkUseGroups.Checked;
        }
        #endregion

    }
}
