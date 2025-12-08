using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXMenu
{
    internal class ViewModel : INotifyPropertyChanged
    {
        //public virtual Message FocusedRow { get; set; }
        public virtual string MailFilter { get; set; }
        public virtual string Header { get; set; }
        public virtual string DateColumnHeader { get; set; }
        public virtual bool ShowMenuOnEmptySpaceBarClick { get; set; }
        //public virtual HamburgerMenuAvailableViewStates AvailableViewStates { get; set; }
        public virtual bool IsFlyoutViewStateEnabled { get; set; }
        public virtual bool IsOverlayViewStateEnabled { get; set; }
        public virtual bool IsInlineViewStateEnabled { get; set; }
        public virtual bool ShowRevealHighlightEffect { get; set; }

        private object _selectedMenuItem;

        public object SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                if (_selectedMenuItem != value) {
                    _selectedMenuItem = value;
                    OnPropertyChanged(nameof(SelectedMenuItem));
                }
            }
        }

        //public IEnumerable<Message> Data { get { return MailItems.Messages; } }
        //public ReadOnlyCollection<HamburgerItemViewModelBase> Items { get; private set; }
        //public ReadOnlyCollection<BottomBarItemViewModelBase> BottomBarItems { get; private set; }
        //public ObservableCollection<CompactModeFilterItem> CompactFilterItems { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
