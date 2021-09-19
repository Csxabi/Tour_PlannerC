using CSTourPlanner.BL;
using CSTourPlanner.DAL;
using CSTourPlanner.M;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CSTourPlanner.VM
{
    public class TourViewModel : INotifyPropertyChanged
    {
        private string _SearchTextstring;

        public string SearchTextstring
        {
            get { return _SearchTextstring; }
            set { _SearchTextstring = value; NotifyPropertyChanged("SearchTextstring"); }
        }

        private Tour tour;
        public Tour Tour
        {
            get { return tour; }
            set { tour = value; NotifyPropertyChanged("Tour"); }
        }

        private Log log;
        public Log Log
        {
            get { return log; }
            set { log = value; NotifyPropertyChanged("Log"); }
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
            Singleton singleton = Singleton.GetLastObject();
            singleton.Tour = Tour;

            #region commands
            AddTourCommand = new AddTourCom(this);
            SaveTourAsFileCommand = new SaveTourCom(this);
            LoadTourAsFileCommand = new LoadTourCom(this);
            DelTourCommand = new DelTourCom(this);
            EditTourCommand = new EditTourCom(this);
            AddLogCommand = new AddLogCom(this);
            SearchTextCommand = new SearchTextCom(this);
            ReportAsPdfCommand = new ReportToPDFCom(this);
            EditLogCommand = new EditLogCom(this);
            DelLogCommand = new DelLogCom(this);
            #endregion
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand SaveTourAsFileCommand { get; set; }
       
        public void SaveTourAsFile()
        {
            if (tour != null)
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\SaveTourFile.txt";

                System.Windows.MessageBox.Show("Tour " + Tour.TourName + " Saved at: " + path);
                File.WriteAllText(path, JsonConvert.SerializeObject(Tour));
            }
            else System.Windows.MessageBox.Show("No tour is Selected...");
        }
        public ICommand LoadTourAsFileCommand { get; set; }
        public void LoadTourAsFile()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\SaveTourFile.txt";
            if (File.Exists(path))
            {
                System.Windows.MessageBox.Show("Tour " + tour.TourName + " Loded from: " + path);

                Tour LoadedTour = JsonConvert.DeserializeObject<Tour>(File.ReadAllText(path));

                AllTours.Add(LoadedTour);
                tour = LoadedTour;
                ///  DataAcessLayer.DatabaseApi.InsertTour(CurrentTour, Tours.Count + 1); inser to database implament latter on inserting ***
            }
            else System.Windows.MessageBox.Show("File does not exist at " + path);
        }
        public ICommand AddTourCommand { get; set; }
       
        public void AddTour()
        {
            AllTours.Add(Tour);
        }
      
        public ICommand DelTourCommand { get; set; }
     
        public void DelTour()
        {
            AllTours.Remove(tour);
        }
        public ICommand EditTourCommand { get; set; }
        public void EditTour()
        {
            
        }
        public ICommand AddLogCommand { get; set; }
        public void AddLog()
        {
            Tour.TourLogs.Add(log);
        }
        public ICommand DelLogCommand { get; set; }
        public void DelLog()
        {
            Tour.TourLogs.Remove(log);
        }
        public ICommand EditLogCommand { get; set; }
        public void EditLog()
        {

        }
        public ICommand ReportAsPdfCommand { get; set; }
        public void ReportAsPdf()
        {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Report.pdf";
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.OpenOrCreate));
            document.Open();

            foreach (Tour t in AllTours)
            {
                Paragraph elements = new Paragraph("Tour Name: " + t.TourName + "\tRoute: " + t.RouteInfo + "\tDistance: " + t.TourDistance + "\tDescription: " + t.TourDescription + "\nTour logs:\n");
                foreach (Log l in t.TourLogs)
                {
                    elements.Add(new Paragraph("Log Date: " + l.Date + "\tLog Momentum: " + l.Momentum + "\tLog Torque: " + l.Torque));
                }
                document.Add(elements);
            }



            document.Close();
            System.Windows.MessageBox.Show("PDF saved: " + path);

        }
        public ICommand SearchTextCommand { get; set; }
        public void SearchText()
        {
            if (SearchTextstring != "")
            {
                string result = "";
                List<Tour> tours = AllTours.ToList().FindAll(x => x.TourName.StartsWith(SearchTextstring));
                if (tours != null)
                {
                    foreach (Tour tour in tours)
                    {
                        result += "Tour Found : " + tour.TourName + "\nTour Description: " + tour.TourDescription +"\n";
                    }

                }
                if (result.Length > 4) System.Windows.MessageBox.Show(result);
                else System.Windows.MessageBox.Show("Tour Not Found...");

            }
        }

    }
}
