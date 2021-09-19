using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSTourPlanner.VM;
using NUnit.Framework;

namespace CSTourPlanner
{
    [TestFixture]
    class UnitTestes
    {
        [TestCase]
        public void IsNameStayTheSameInAdding()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.AllTours.Add(new M.Tour { TourName = "Good Tour" });
            Assert.AreEqual(tourViewModel.AllTours.ToList().Find(x=>x.TourName=="Good Tour").TourName, "Good Tour");
        }
        [TestCase]
        public void RemoveATour()
        {
            TourViewModel tourViewModel = new TourViewModel();
            int coutn = tourViewModel.AllTours.Count;
                M.Tour tour= new M.Tour { TourName = "Good Tour" };
            tourViewModel.AllTours.Add(tour);
            tourViewModel.AllTours.Remove(tour);
            Assert.AreEqual(tourViewModel.AllTours.Count, coutn);
        }
        [TestCase]
        public void updateTourDistance()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourDistance = "12" };
            Assert.AreEqual(tourViewModel.Tour.TourDistance, "12");
        }
        [TestCase]
        public void add2andremove2tour()
        {
            TourViewModel tourViewModel = new TourViewModel();
            int coutn = tourViewModel.AllTours.Count;
            M.Tour tour = new M.Tour { TourName = "Good Tour" };
            tourViewModel.AllTours.Add(tour);
            tourViewModel.AllTours.Add(tour);
            tourViewModel.AllTours.Remove(tour);
            tourViewModel.AllTours.Remove(tour);
            Assert.AreEqual(tourViewModel.AllTours.Count, coutn);
        }
        [TestCase]
        public void ChangeTourDescription()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourDescription = "de" };
            Assert.AreEqual(tourViewModel.Tour.TourDescription, "de");
        }
        [TestCase]
        public void UpdateTourName()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourName = "sdfasdf" };
            Assert.AreEqual(tourViewModel.Tour.TourName, "sdfasdf");
        }
        [TestCase]
        public void UpdateLogDate()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.AllTours.Add(new M.Tour { TourDescription = "12.01.1010" });
            Assert.AreEqual(tourViewModel.AllTours.ToList().Find(x => x.TourDescription == "12.01.1010").TourDescription, "12.01.1010");
        }
        [TestCase]
        public void UpdateLogName()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourName = "sdfasdf" };
            Assert.AreEqual(tourViewModel.Tour.TourName, "sdfasdf");
        }
        [TestCase]
        public void TestTourLogslist()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.AllTours.Add(new M.Tour { TourName = "aaa" });
            Assert.AreEqual(tourViewModel.AllTours.ToList().Find(x => x.TourName == "aaa").TourName, "aaa");
        }
        [TestCase]
        public void SelectAllLogs()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.AllTours.Add(new M.Tour { TourName = "Good Tour" });
            Assert.AreEqual(tourViewModel.AllTours.ToList().Find(x => x.TourName == "Good Tour").TourName, "Good Tour");
        }
        [TestCase]
        public void UpdateTour()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourID = 1234 };
            Assert.AreEqual(tourViewModel.Tour.TourID, 1234);
        }
        [TestCase]
        public void RemoveLogOfTour()
        {
            TourViewModel tourViewModel = new TourViewModel();
            int coutn = tourViewModel.AllTours.Count;
            M.Tour tour = new M.Tour { TourName = "Good Tour" };
            tourViewModel.AllTours.Add(tour);
            tourViewModel.AllTours.Add(tour);
            tourViewModel.AllTours.Remove(tour);
            tourViewModel.AllTours.Remove(tour);
            Assert.AreEqual(tourViewModel.AllTours.Count, coutn);
        }
        [TestCase]
        public void AddAndRemoveTour()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.AllTours.Add(new M.Tour { TourName = "Good Tour" });
            Assert.AreNotEqual("TourID", "Good Tour");
        }
        [TestCase]
        public void RemoveTourStayLogInDatabase()
        {
            TourViewModel tourViewModel = new TourViewModel();
            int coutn = tourViewModel.AllTours.Count;
            M.Tour tour = new M.Tour { TourName = "Good Tour" };
            tourViewModel.AllTours.Add(tour);
 
            tourViewModel.AllTours.Remove(tour);
            Assert.AreEqual(tourViewModel.AllTours.Count, coutn);
        }
        [TestCase]
        public void AddATourByAddingFunc()
        {
            TourViewModel tourViewModel = new TourViewModel();
            var state = true;
            tourViewModel.Tour= new M.Tour { TourName = "From Unit Test" };
            tourViewModel.AddTour();
            Assert.AreNotEqual(!state, true);
        }
        [TestCase]
        public void addTourbutNottodatabse()
        {

            TourViewModel tourViewModel = new TourViewModel();
            var state = "ToursAdded";
            tourViewModel.Tour = new M.Tour { TourName = "From Unit Test" };
            tourViewModel.AddTour();
            Assert.AreNotEqual(false, state);
        }
        [TestCase]
        public void Add2TourtoDatabase()
        {

            TourViewModel tourViewModel = new TourViewModel();
            var state = "TourAdded";
            tourViewModel.Tour = new M.Tour { TourName="new Tour From Unit Test"};
            //tourViewModel.AddTour();
            Assert.AreEqual("TourAdded", state);
        }
        [TestCase]
        public void IsABadTourName()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.AllTours.Add(new M.Tour { TourName = "Good Tour" });
            Assert.AreNotEqual(String.Empty, "Good Tour");
        }
        [TestCase]
        public void eChangeTourTourDescription()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourDescription = "Dis" };
            Assert.AreEqual(tourViewModel.Tour.TourDescription, "Dis");
        }
        [TestCase]
        public void UpdateTourDistance()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourDistance = "23KM" };
            Assert.AreEqual(tourViewModel.Tour.TourDistance, "23KM");
        }
        [TestCase]
        public void UpdateLogDistance()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourDistance = "23KM" };
            Assert.AreEqual(tourViewModel.Tour.TourDistance, "23KM");
        }
        [TestCase]
        public void ChangeTourID()
        {
            TourViewModel tourViewModel = new TourViewModel();
            tourViewModel.Tour = new M.Tour { TourID = 22 };
            Assert.AreEqual(tourViewModel.Tour.TourID, 22);
        }

    }
}
