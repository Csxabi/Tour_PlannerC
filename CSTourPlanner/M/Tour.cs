using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTourPlanner.M
{
    public class Tour : INotifyPropertyChanged
    {
        public Tour()
        {
            TourLogs = new ObservableCollection<Log>();
        }

        private int tourID;
        public int TourID
        {
            get { return tourID; }
            set { tourID = value; OnPropertyChanged("TourID"); }
        }

        private string tourName;
        public string TourName
        {
            get { return tourName; }
            set { tourName = value; OnPropertyChanged("TourName"); }
        }
        private string tourDescription;
        public string TourDescription
        {
            get { return tourDescription; }
            set { tourDescription = value; OnPropertyChanged("TourDescription"); }
        }


        private ObservableCollection<Log> _TourLogs;
        public ObservableCollection<Log> TourLogs
        {
            get { return _TourLogs; }
            set { _TourLogs = value; OnPropertyChanged("TourLogs"); }
        }

        private string _RouteInfo;
        public string RouteInfo
        {
            get { return _RouteInfo; }
            set { _RouteInfo = value; OnPropertyChanged("RouteInfo"); }
        }

        private string _TourDistance;

        public event PropertyChangedEventHandler PropertyChanged;

        public string TourDistance
        {
            get { return _TourDistance; }
            set { _TourDistance = value; OnPropertyChanged("TourDistance"); }
        }

        private void OnPropertyChanged(string pro)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null) ph(this, new PropertyChangedEventArgs(pro));
        }
    }
}
