using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for ProjectMainWindow.xaml
    /// </summary>
    public partial class ProjectMainWindow : Window
    {
        public ProjectMainWindow()
        {
            InitializeComponent();
        }
        private void AddTrip_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AddTrip();
            window.Show();

        }

        private void Trip_Click(object sender, RoutedEventArgs e)
        {
            Window window = new BrowseTrips();
            window.Show();
        }

        private void BrowseDestinations_Click(object sender, RoutedEventArgs e)
        {
            Window window = new BrowseDestinations();
            window.Show();
        }

        private void AddDestination_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AddDestination();
            window.Show();
        }
    }
}
