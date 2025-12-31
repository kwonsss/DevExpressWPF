using CommunityToolkit.Mvvm.Input;
using DevExpress.Xpf.Core;
using DXWPFSkeleton.Core;
using DXWPFSkeleton.Data;
using DXWPFSkeleton.Util;
using DXWPFSkeleton.ViewModels;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;

namespace DXWPFSkeleton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private bool MainExit = false;

        private MainViewModel ViewModel = new ();

        private DataSet DataSet = DataSet.Instance;

        private Logger Logger = Logger.Instance;

        private Engine Engine = Engine.Instance;

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = ViewModel;

            ViewModel.StopCommand = new RelayCommand<object>(OnStop);
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await Engine.Initialize();

            Engine.Run();
        }
        private async void Window_Closing(object sender, CancelEventArgs e)
        {
            if (MainExit)
                return;

            e.Cancel = true;

            var result = ThemedMessageBox.Show("INFO", "어플리케이션을 종료 하시겠습니까?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result != MessageBoxResult.Yes) {
                return;
            }

            MainExit = true;

            await ExitSystem();

            Logger.Write(LEVEL.INFO, "(Exit)");

            // 종료
            Application.Current.Shutdown();
        }
        /// <summary>
        /// 프로그램 종료
        /// </summary>
        private async Task ExitSystem()
        {
            DataSet.CTS.Cancel();

            await Task.Delay(1000);
        }
        private void TopBarItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            var item = e.Item.Content as string;

            if (item != null) {
                switch (item) {
                    case "Minimize":
                        this.ResizeMode = ResizeMode.CanResize;
                        this.WindowState = WindowState.Minimized;
                        break;
                    case "Normal":
                        this.ResizeMode = ResizeMode.CanResize;
                        this.WindowState = WindowState.Normal;
                        this.WindowScreenBar.Content = "Maximize";
                        break;
                    case "Maximize":
                        this.ResizeMode = ResizeMode.NoResize;
                        this.WindowState = WindowState.Maximized;
                        this.WindowScreenBar.Content = "Normal";
                        break;
                    case "Exit":
                        this.Close();
                        break;

                }
            }
        }
        private void TopBar_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
                DragMove();
        }
        private void OnStop(object sender)
        {

        }


    }
}
