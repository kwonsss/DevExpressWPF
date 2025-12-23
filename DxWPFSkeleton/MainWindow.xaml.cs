using CommunityToolkit.Mvvm.Input;
using DevExpress.Xpf.Core;
using DXWPFSkeleton.Core;
using DXWPFSkeleton.ViewModels;
using System.Windows;

namespace DXWPFSkeleton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private MainViewModel ViewModel = new ();

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
        private void OnStop(object sender)
        {

        }
    }
}
