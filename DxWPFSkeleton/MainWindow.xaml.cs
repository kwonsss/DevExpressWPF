using DXWPFSkeleton.Core;
using DevExpress.Xpf.Core;
using System.Windows;

namespace DXWPFSkeleton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private Engine Engine = Engine.Instance;

        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await Engine.Initialize();

            Engine.Run();
        }
    }
}
