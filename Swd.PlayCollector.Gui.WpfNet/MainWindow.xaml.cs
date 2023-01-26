using Swd.PlayCollector.DataNet;
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

namespace Swd.PlayCollector.Gui.WpfNet
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            Location loc = new Location();
            loc.Name = "Testlocation";


            Location loc1 = new Location();
            loc1.Name = "Testlocation";

            Swd.PlayCollector.DataNet.PlayCollector model = new Swd.PlayCollector.DataNet.PlayCollector();
            model.Locations.Add(loc);
            model.SaveChanges();

            model.Locations.Add(loc1);
            model.SaveChanges();

            List<Location> list = new List<Location>();
            list = model.Locations.ToList();

            Location firstLocation = model.Locations.Find(1);

            Location newLocation = model.Locations.Where(l=>l.Id == 2).FirstOrDefault();




        }
    }
}
