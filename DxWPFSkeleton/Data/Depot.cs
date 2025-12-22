using System;

namespace DXWPFSkeleton.Data
{
    /// <summary>
    /// PLC 장비 데이타
    /// </summary>
    public class Depot
    {
        private static readonly Lazy<Depot> lazy = new Lazy<Depot>(() => new Depot());

        public static Depot Instance { get { return lazy.Value; } }


    }

}
