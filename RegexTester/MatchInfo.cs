using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexTester
{
    public struct MatchInfo
    {
        #region Declarations
        //***************************************************************************
        // Public Fields
        // 
        public static readonly MatchInfo
            Empty;
        public readonly int
            Start, Length;
        public readonly string
            Value;
        public GroupInfoCollection
            Groups;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public MatchInfo(System.Text.RegularExpressions.Match m, string[] groupNms)
            : this(m.Index, m.Length, m.Value, m.Groups, groupNms)
        { }
        public MatchInfo(int start, int len, string value, GroupCollection group, string[] groupNms)
        {
            this.Start = start;
            this.Length = len;
            this.Value = value;
            this.Groups = new GroupInfoCollection();
            this.Groups.ReturnNullForKeyNotFound = true;
            for (int i = 0; i < group.Count; i++)
                this.Groups.Add(new GroupInfo(this, group[i], groupNms[i], i), i.ToString());
        }
        #endregion
    }
    public class MatchInfoCollection : RainstormStudios.Collections.ObjectCollectionBase<MatchInfo>
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string Add(MatchInfo m)
        {
            return this.Add(m, string.Empty);
        }
        public string Add(MatchInfo m, string key)
        {
            return base.Add(m, key);
        }
        public void Remove(MatchInfo m)
        {
            base.RemoveAt(this.IndexOf(m));
        }
        public string Insert(int index, MatchInfo m)
        {
            return this.Insert(index, m);
        }
        public string Insert(int index, MatchInfo m, string key)
        {
            return base.Insert(index, m, key);
        }
        #endregion

        #region Non-Public Methods
        //***************************************************************************
        // Private Methods
        // 
        #endregion
    }
    public struct GroupInfo
    {
        #region Declarations
        //***************************************************************************
        // Public Fields
        // 
        public static readonly GroupInfo
            Empty;
        public readonly MatchInfo
            Owner;
        public string
            GroupName,
            Value;
        public int
            Start,
            Length,
            GroupNumber;
        public CaptureCollection
            Captures;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public GroupInfo(MatchInfo ownr, Group g, string grpNm, int groupId)
            : this(ownr, g.Index, g.Length, g.Value, g.Captures, grpNm, groupId)
        { }
        public GroupInfo(MatchInfo ownr, int start, int length, string value, CaptureCollection caps, string grpNm, int groupId)
        {
            this.Owner = ownr;
            this.Start = start;
            this.Length = length;
            this.Value = value;
            this.GroupName = grpNm;
            this.Captures = caps;
            this.GroupNumber = groupId;
        }
        #endregion
    }
    public class GroupInfoCollection : RainstormStudios.Collections.ObjectCollectionBase<GroupInfo>
    {
        #region Properties
        //***************************************************************************
        // Public Properties
        // 
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public string Add(GroupInfo value)
        {
            return this.Add(value, string.Empty);
        }
        public string Add(GroupInfo value, string key)
        {
            return base.Add(value, key);
        }
        public string Insert(int index, GroupInfo value)
        {
            return this.Insert(index, value, string.Empty);
        }
        public string Insert(int index, GroupInfo value, string key)
        {
            return base.Insert(index, value, key);
        }
        public void Remove(GroupInfo value)
        {
            base.RemoveAt(this.IndexOf(value));
        }
        #endregion

        #region Non-Public Methods
        //***************************************************************************
        // Private Methods
        // 
        #endregion
    }
}
