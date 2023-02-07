using Swd.PlayCollector.Business;
using Swd.PlayCollector.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Gui.Wpf.ViewModel
{
    public class MainWindowsViewModel
    {
        private string _searchCriteria;
        private string _searchCriteriaHelpText;
        private List<CollectionItem> _collectionItems;


        public string SearchCriteria
        {
            get { return _searchCriteria; }
            set { _searchCriteria = value; }
        }

        public string SearchCriteriaHelpText
        {
            get { return _searchCriteriaHelpText; }
            set { _searchCriteriaHelpText = value; }
        }

        public List<CollectionItem> CollectionItems
        {
            get { return _collectionItems; }
            set { _collectionItems = value; }
        }


        public MainWindowsViewModel()
        {
            SearchCriteriaHelpText = "Bitte Suchbegriff eingeben...";
            Init();

        }

        private async Task Init()
        {
            CollectionItemService service = new CollectionItemService();
            CollectionItems = new List<CollectionItem>(await service.GetAllAsync());

        }


    }
}
