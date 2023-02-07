using Microsoft.EntityFrameworkCore;
using Swd.PlayCollector.Business;
using Swd.PlayCollector.Gui.Wpf.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Swd.PlayCollector.Gui.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowsViewModel();
        }



        private async void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            //CollectionItemService service = new CollectionItemService();
            //this.grdCollectionItems.ItemsSource = await service.GetAllAsync().Result.ToListAsync();
        }
    }
}
