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
        Connection cnn1 = new Connection();
        public ProjectMainWindow()
        {
            InitializeComponent();
            cnn1.connect();
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Connection cnn = new Connection();
            cnn.connect();
        }
        private void AddTrip_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AddTrip();
            window.Show();

        }
    }
}
