using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTourPlanner.M
{
    public class Tour
    {
        public Tour()
        {
            TourLogs = new ObservableCollection<Log>();
        }
        public int TourID { get; set; }
        public ObservableCollection<Log> TourLogs { get; set; }
        public string TourName { get; set; }
        public string TourDescription { get; set; }
        public string RouteInfo { get; set; }
        public string TourDistance { get; set; }
    }
}
