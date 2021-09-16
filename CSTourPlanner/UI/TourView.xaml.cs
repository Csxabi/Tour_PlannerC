﻿using System;
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
            LogsLV.Items.Add("ali");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new EditLogView().ShowDialog();
        }
    }
}
