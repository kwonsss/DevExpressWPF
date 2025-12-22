using System;

namespace DXWPFSkeleton.Common
{
    public static class Broadcast
    {
        public static event EventHandler<EventArgs> UpdatePLC;

        public static event EventHandler<EventArgs> UpdateRun;

        public static event EventHandler<StateArgs> UpdateState;

        public static void RaisePLC()
        {
            UpdatePLC?.Invoke(null, EventArgs.Empty);
        }
        public static void RaiseRun()
        {
            UpdateRun?.Invoke(null, EventArgs.Empty);
        }
        public static void RaiseState(string json)
        {
            UpdateState?.Invoke(null, new StateArgs(json));
        }
    }
}
