using CSTourPlanner.DAL;
using CSTourPlanner.VM;
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
using System.Windows.Shapes;

namespace CSTourPlanner.UI
{
    /// <summary>
    /// TourView.xaml etkileşim mantığı
    /// </summary>
    public partial class TourView : Window
    {
        public TourView()
        {
            InitializeComponent();
            ViewModel = new TourViewModel();
            this.DataContext = ViewModel;
          

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
            InitializeComponent();
        }
    }
}
