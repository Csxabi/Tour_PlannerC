using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTourPlanner.M
{
    public class Log : INotifyPropertyChanged
    {
        private int _LogID;

        public int LogID
        {
            get { return _LogID; }
            set { _LogID = value; OnPropertyChanged("LogID"); }
        }

        private int _TourID;

        public int TourID
        {
            get { return _TourID; }
            set { _TourID = value; OnPropertyChanged("TourID"); }
        }

        private int _Rating;

        public int Rating
        {
            get { return _Rating; }
            set { _Rating = value; OnPropertyChanged("Rating"); }
        }

        private string _Distance;

        public string Distance
        {
            get { return _Distance; }
            set { _Distance = value; OnPropertyChanged("Distance"); }
        }

        private string _Joule;

        public string Joule
        {
            get { return _Joule; }
            set { _Joule = value; OnPropertyChanged("Joule"); }
        }
        private string _Torque;

        public string Torque
        {
            get { return _Torque; }
            set { _Torque = value; OnPropertyChanged("Torque"); }
        }

        private string _TotalTime;

        public string TotalTime
        {
            get { return _TotalTime; }
            set { _TotalTime = value; OnPropertyChanged("TotalTime"); }
        }
        private string _Momentum;

        public string Momentum
        {
            get { return _Momentum; }
            set { _Momentum = value; OnPropertyChanged("Momentum"); }
        }
        private string _Date;

        public string Date
        {
            get { return _Date; }
            set { _Date = value; OnPropertyChanged("Date"); }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(string pro)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null) ph(this, new PropertyChangedEventArgs(pro));
        }
    }
}
