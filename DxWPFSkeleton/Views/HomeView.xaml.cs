using CommunityToolkit.Mvvm.Input;
using DXWPFSkeleton.Util;
using DXWPFSkeleton.ViewModels;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Controls;

namespace DXWPFSkeleton.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        private static long InterCounter = 0;

        private HomeViewModel ViewModel = new HomeViewModel();

        private Logger Logger = Logger.Instance; 

        public HomeView()
        {
            InitializeComponent();

            this.DataContext = ViewModel;

            ViewModel.AngleExecuteCommand = new RelayCommand(OnAngleExecute);
        }

        #region Event
        /// <summary>
        /// Angle 실행
        /// </summary>
        private void OnAngleExecute()
        {

        }

        private void Engine_UpdateRender(object sender, EventArgs e)
        {
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                if (Interlocked.Read(ref InterCounter) > 0) {
                    Debug.WriteLine($"{DateTime.Now} : Skip Frame");
                    return;
                }

                try {

                    Interlocked.Increment(ref InterCounter);
                }
                catch (Exception ex) {
                    Debug.WriteLine($"{ex}");
                }
                finally {
                    Interlocked.Decrement(ref InterCounter);
                }

            }));

        }
        #endregion


    }
}
