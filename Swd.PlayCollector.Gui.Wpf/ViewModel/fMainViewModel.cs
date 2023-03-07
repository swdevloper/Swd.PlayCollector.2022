using CommunityToolkit.Mvvm.ComponentModel;
using Swd.PlayCollector.Business;
using Swd.PlayCollector.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Gui.Wpf.ViewModel
{
    public partial class fMainViewModel: ObservableObject
    {
        private string _searchValue;
        private string _statusBarText;
        private CollectionItem _selectedCollectionItem;
        private ObservableCollection<CollectionItem> _collectionItemsList;
        private ObservableCollection<Location> _locationList;
        private ObservableCollection<Theme> _themeList;

        public string SearchValue
        {
            get { return _searchValue; }
            set { SetProperty(ref _searchValue, value); }
        }
        public string StatusBarText
        {
            get { return GetStatusBarText(); }
            set { SetProperty(ref _statusBarText, value); }
        }
        public CollectionItem SelectedCollectionItem
        {
            get { return _selectedCollectionItem; }
            set { SetProperty(ref _selectedCollectionItem, value); }
        }
        public ObservableCollection<CollectionItem> CollectionItemsList
        {
            get { return _collectionItemsList; }
            set { SetProperty(ref _collectionItemsList, value); }
        }
        public ObservableCollection<Location> LocationList
        {
            get { return _locationList; }
            set { SetProperty(ref _locationList, value); }
        }
        public ObservableCollection<Theme> ThemeList
        {
            get { return _themeList; }
            set { SetProperty(ref _themeList, value); }
        }

        public fMainViewModel()
        {

            this.StatusBarText = string.Empty;
            LoadDataAsync();

        }


        private async Task LoadDataAsync()
        {
            CollectionItemService collectionItemService = new CollectionItemService();


            Task<IQueryable<CollectionItem>> getCollectionItemTaks = collectionItemService.GetAllAsync();


            this.CollectionItemsList = new ObservableCollection<CollectionItem>(await getCollectionItemTaks);

        }


        private string GetStatusBarText()
        {
            return string.Format("{0} items found.", this.CollectionItemsList.Count);
        }

    }
}
