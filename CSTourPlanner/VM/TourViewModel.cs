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

        public Tour Tour { get; set; }
        public ObservableCollection<Tour> AllTours { get; set; }

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

        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
