using DevExpress.Xpf.Core;

namespace DXMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private ViewModel ViewModel = new ViewModel();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = ViewModel;
        }
    }
}
