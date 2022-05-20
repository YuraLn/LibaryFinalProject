using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LibaryFinalProject.View;
using System.Windows.Input;

namespace LibaryFinalProject.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
           
        }
        private RelayCommand showItemsView;
        public ICommand ShowItemsView
        {
            get
            {
                if (showItemsView == null)
                {
                    showItemsView = new RelayCommand(PerformShowItemsView);
                }

                return showItemsView;
            }
        }

        private void PerformShowItemsView()
        {
            var win = new ShowItemsView();
            win.Show();
        }

        private System.Collections.IEnumerable itemList;

        public System.Collections.IEnumerable ItemList { get => itemList; set => Set(ref itemList, value); }
    }
}