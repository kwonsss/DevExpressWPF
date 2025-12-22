using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DXWPFSkeleton.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        /// <summary>
        /// LAN XI 스트림
        /// </summary>
        [ObservableProperty]
        private bool isReadyLanXI;

        /// <summary>
        /// 동작중
        /// </summary>
        [ObservableProperty]
        private bool isPLCRunning;
        [ObservableProperty]
        private bool isLANXIRunning;

        [ObservableProperty]
        private float current1;
        [ObservableProperty]
        private float current2;
        [ObservableProperty]
        private float current3;
        [ObservableProperty]
        private float current4;

        [ObservableProperty]
        private float target1;
        [ObservableProperty]
        private float target2;
        [ObservableProperty]
        private float target3;
        [ObservableProperty]
        private float target4;

        [ObservableProperty]
        private string moduleState = "None";

        [ObservableProperty]
        private string captureExecute = "Execute";

        [ObservableProperty]
        private int time = 1;


        public IRelayCommand AngleExecuteCommand           { get; set; }

        public IRelayCommand RecorderOpenCommand    { get; set; }
        public IRelayCommand RecorderCloseCommand   { get; set; }

        public IRelayCommand StreamStartCommand     { get; set; }
    }
}
