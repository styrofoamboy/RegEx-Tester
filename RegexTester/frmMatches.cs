using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace RegexTester
{
    public partial class frmMatches : DockContent
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private MatchInfoCollection
            _miCol;
        //***************************************************************************
        // Event Definitions
        // 
        public event TreeViewEventHandler TreeNodeSelectionChanged;
        #endregion

        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        public TreeNodeCollection Nodes
        {
            get { return this.trvMatches.Nodes; }
        }
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmMatches()
        {
            InitializeComponent();
            this._miCol = new MatchInfoCollection();
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public void BeginUpdate()
        {
            this.trvMatches.BeginUpdate();
        }
        public void EndUpdate()
        {
            this.trvMatches.EndUpdate();
        }
        public TreeNode AddRegExMatch(System.Text.RegularExpressions.Match m, string[] groupNames)
        {
            TreeNode ndMatch = new TreeNode();
            ndMatch.Name = "nd_Match_" + m.Index + "_" + m.Length;
            ndMatch.Text = m.Value;
            ndMatch.SelectedImageIndex = ndMatch.ImageIndex = 0;
            MatchInfo mi = new MatchInfo(m, groupNames);
            for (int i = 1; i < m.Groups.Count; i++)
            {
                TreeNode ndCapt = new TreeNode();
                ndCapt.Name = ndMatch.Name + "=" + m.Groups[i].Index + "_" + m.Groups[i].Length;
                ndCapt.Text = (string.IsNullOrEmpty(groupNames[i]) ? i.ToString() : groupNames[i]) + ": [" + m.Groups[i].Value + "]";
                ndCapt.SelectedImageIndex = ndCapt.ImageIndex = 1;
                ndCapt.Tag = i;
                ndMatch.Nodes.Add(ndCapt);
            }
            ndMatch.Tag = this._miCol.Add(mi);
            this.trvMatches.Nodes.Add(ndMatch);
            return ndMatch;
        }
        public void Clear()
        {
            this.Nodes.Clear();
            this._miCol.Clear();
        }
        public MatchInfo GetNodeMatch(TreeNode nd)
        {
            if (nd.Tag != null)
                return this._miCol[nd.Tag.ToString()];
            else
                return MatchInfo.Empty;
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void ExportMatchList()
        {
            string fn = string.Empty;

            RainstormStudios.Collections.StringCollection allGrps = new RainstormStudios.Collections.StringCollection();
            for (int i = 0; i < this._miCol.Count; i++)
                for (int j = 0; j < this._miCol[i].Groups.Count; j++)
                    allGrps.AddUnique(this._miCol[i].Groups[j].GroupName);

            using (frmExportMatchList frm = new frmExportMatchList(allGrps.ToArray()))
            {
                if (frm.ShowDialog(this) != DialogResult.OK)
                    return;

                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.DefaultExt = ".txt";
                    dlg.Filter = "Text Files|*.txt|All Files|*.*";
                    dlg.FilterIndex = 0;
                    dlg.Title = "Please Select Output File";
                    dlg.ValidateNames = true;
                    dlg.OverwritePrompt = true;
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        fn = dlg.FileName;
                    else
                        // User canceled save file dialog.
                        return;
                }

                List<string> ExportedGroupList = frm.IncludedGroupNames;

                using (System.IO.FileStream fs = new System.IO.FileStream(fn, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(fs))
                {
                    RainstormStudios.Collections.ObjectCollection
                        grpCol = new RainstormStudios.Collections.ObjectCollection();

                    int maxGrpNameLen = -1;

                    if (frm.IncludeMaster)
                        sr.WriteLine("[Matches]");
                    for (int i = 0; i < this._miCol.Count; i++)
                    {
                        MatchInfo mi = this._miCol[i];
                        if (frm.IncludeMaster)
                            sr.WriteLine(mi.Value);

                        if (frm.IncludeGroups)
                        {
                            if(maxGrpNameLen==-1)
                            {
                                for (int j = 0; j < mi.Groups.Count; j++)
                                    if (mi.Groups[j].GroupName.Length > maxGrpNameLen)
                                        maxGrpNameLen = mi.Groups[j].GroupName.Length;
                            }

                            for (int j = 0; j < mi.Groups.Count; j++)
                            {
                                string grpNm = mi.Groups[j].GroupName;
                                if (!ExportedGroupList.Contains(grpNm))
                                    continue;

                                if (frm.Mode == frmExportMatchList.ExportMode.NestedList)
                                {
                                    sr.WriteLine("{0}: {1}", grpNm.PadRight(maxGrpNameLen + 2, ' '), mi.Groups[j].Value);
                                }
                                else if (frm.Mode == frmExportMatchList.ExportMode.SeparatedLists)
                                {
                                    if (!grpCol.ContainsKey(grpNm))
                                        grpCol.Add(new RainstormStudios.Collections.StringCollection(), grpNm);

                                    ((RainstormStudios.Collections.StringCollection)grpCol[grpNm]).Add(mi.Groups[j].Value);
                                }
                            }
                            if (frm.Mode == frmExportMatchList.ExportMode.NestedList)
                                sr.WriteLine();
                        }
                    }

                    if (frm.IncludeGroups && frm.Mode == frmExportMatchList.ExportMode.SeparatedLists)
                    {
                        for (int k = 0; k < grpCol.Count; k++)
                        {
                            if (frm.IncludeMaster || k > 0)
                                sr.WriteLine();
                            sr.WriteLine("[" + grpCol.GetKey(k) + "]");

                            RainstormStudios.Collections.StringCollection valCol = (RainstormStudios.Collections.StringCollection)grpCol[k];
                            for (int l = 0; l < valCol.Count; l++)
                                sr.WriteLine(valCol[l]);
                        }
                    }
                }
            }
            MessageBox.Show(this, "Export Complete!", "Success!");
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tsbExportList":
                    this.ExportMatchList();
                    break;
            }
        }
        private void trvMatches_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.TreeNodeSelectionChanged != null)
                this.TreeNodeSelectionChanged.Invoke(sender, e);
        }
        private void ctxMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "ctxMnuExportResults":
                    this.ExportMatchList();
                    break;
            }
        }
        #endregion
    }
}
