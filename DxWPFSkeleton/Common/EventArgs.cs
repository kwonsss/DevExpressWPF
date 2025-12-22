using System;

namespace DXWPFSkeleton.Common
{

    public class StateArgs : EventArgs
    {
        public string Value     { get; set; }

        public StateArgs(string value)
        {
            Value = value;
        }
    }
}
