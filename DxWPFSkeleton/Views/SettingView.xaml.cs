using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DXWPFSkeleton.Views
{
    /// <summary>
    /// SettingView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SettingView : UserControl
    {
        public static readonly DependencyProperty StopButtonProperty = DependencyProperty.Register(
            "StopButtonCommand", typeof(ICommand), typeof(SettingView), new FrameworkPropertyMetadata(null));
        public ICommand StopButtonCommand
        {
            get { return (ICommand)GetValue(StopButtonProperty); }
            set { SetValue(StopButtonProperty, value); }
        }

        public SettingView()
        {
            InitializeComponent();
        }
    }
}
