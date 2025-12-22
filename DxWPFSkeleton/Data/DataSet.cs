using System;

namespace DXWPFSkeleton.Data
{
    public class DataSet
    {
        private static readonly Lazy<DataSet> lazy = new Lazy<DataSet>(() => new DataSet());

        public static DataSet Instance { get { return lazy.Value; } }

        public bool IsPLCRun        { get; set; }
        public bool IsLANXIRun      { get; set; }

    }
}
