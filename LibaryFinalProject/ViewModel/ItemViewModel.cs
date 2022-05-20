/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:LibaryFinalProject"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LibaryFinalProject.Model;
using System.Collections.ObjectModel;

namespace LibaryFinalProject.ViewModel
{
    public class ItemViewModel : ViewModelBase
    {
        public string Title { get; set; }
        public Book NewBook { get; set; }
        public RelayCommand AddItemCommand { get; set; }
        public ObservableCollection<Book> Items { get; set; }
        public Book SelectedName { get; set; }


        public ItemViewModel()
        {
            NewBook = new Book();
            AddItemCommand = new RelayCommand(AddItem);
            Items = new ObservableCollection<Book>();
        }

        private void AddItem()
        {
            NewBook = new Book { Title = this.Title };
            Items.Add(NewBook);
            MessengerInstance.Send(Items.Count);
            MessengerInstance.Send(NewBook);
        }

    }
}