using CSTourPlanner.DAL;
using CSTourPlanner.VM;
using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSTourPlanner.UI
{
    
    public partial class TourView : Window
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TourView()
        {
            InitializeComponent();
            ViewModel = new TourViewModel();
            this.DataContext = ViewModel;
            log.Debug("model view is working well...");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new EditLogView().ShowDialog();
        }
        private TourViewModel ViewModel;

        private void ToursListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if(ToursListBox.SelectedItem!=null)
            ViewModel.Tour = new DBA().GetTours()[0];
     
        }

        private void MapLoadBtn(object sender, RoutedEventArgs e)
        {
            Singleton singleton = Singleton.GetLastObject();
            M.Tour Current =singleton.Tour;
            Current.RouteInfo = Routeb.Text;
                if (Current.RouteInfo != string.Empty)
                {

                try
                {
                    string apiLink = "https://www.mapquestapi.com/staticmap/v5/map?key=ENC6vtgWXGlFY0zvJoevS5Ek2XN5Kmkc&center=" + Current.RouteInfo.Replace(' ', '+') + "&zoom=11&type=hyb&size=600,400@2x";
                    if (Current.RouteInfo.Contains("-"))
                    {
                        string start = "", stop = "";
                        string route = Current.RouteInfo.Replace(' ', '+');
                        string[] Routesplited = route.Split('-');
                        start = Routesplited[0]; stop = Routesplited[1];
                        apiLink = "https://www.mapquestapi.com/staticmap/v5/map?start=" + start + "&end=" + stop + "&size=@2x&key=ENC6vtgWXGlFY0zvJoevS5Ek2XN5Kmkc&type=hyb";
                    }

                    mapImage.Source = LoadImage(new WebClient().DownloadData(apiLink));
                }
                catch
                {
                    MessageBox.Show("Could not download from map api...");
                }

                }
        }

        BitmapSource LoadImage(Byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                var decoder = BitmapDecoder.Create(ms, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                return decoder.Frames[0];
            }
        }
    }
}
