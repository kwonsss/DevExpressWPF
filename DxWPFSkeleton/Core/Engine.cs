
using DXWPFSkeleton.Data;
using DXWPFSkeleton.Util;
using System;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DXWPFSkeleton.Core
{
    internal class Engine
    {
        private static readonly Lazy<Engine> lazy = new Lazy<Engine>(() => new Engine());
        public static Engine Instance { get { return lazy.Value; } }

        private Logger Logger = Logger.Instance;

        private DataSet DataSet = DataSet.Instance;

     
        public event EventHandler<EventArgs>  UpdateRender;


        // 그래프 
        public Channel<int> TicketChannel    { get; set; }

        public Engine()
        {

            TicketChannel = Channel.CreateBounded<int>(new BoundedChannelOptions(1000)
            {
                FullMode = BoundedChannelFullMode.DropOldest
            });
        }

        public async Task Initialize()
        {

            try {

                Logger.Write(LEVEL.INFO, "Initialize");
            }
            catch (Exception ex) {
                Logger.Write(LEVEL.ERROR, ex.ToString());
            }

        }
        public void Run()
        {

            try {

                // 그래프
                Task.Factory.StartNew(Render, TaskCreationOptions.LongRunning);

                Logger.Write(LEVEL.INFO, "Task Run");
            }
            catch (Exception ex) {
                Logger.Write(LEVEL.ERROR, ex.ToString());
            }

        }


        public async Task Render()
        {
            while (true) {

                await Task.Delay(100);

            }
        }
    }
}
