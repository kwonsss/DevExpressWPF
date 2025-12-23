using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DXWPFSkeleton.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public IRelayCommand<object> StopCommand { get; set; }
    }
}
