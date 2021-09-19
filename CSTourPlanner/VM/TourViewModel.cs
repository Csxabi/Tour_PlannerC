using CSTourPlanner.DAL;
using CSTourPlanner.M;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSTourPlanner.VM
{
    public class TourViewModel : INotifyPropertyChanged
    {

        private Tour tour;
        public Tour Tour
        {
            get { return tour; }
            set { tour = value; NotifyPropertyChanged("Tour"); }
        }
       
        private ObservableCollection<Tour> _AllTours;

        public ObservableCollection<Tour> AllTours
        {
            get { return _AllTours; }
            set { _AllTours = value; NotifyPropertyChanged("AllTours"); }
        }
        public TourViewModel()
        {
            AllTours = new ObservableCollection<Tour>();
            Tour = new Tour();
            foreach(Tour tour in new DBA().GetTours())
            {
                
                AllTours.Add(tour);
           
            }
            
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
