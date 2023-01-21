using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for BrowseTrips.xaml
    /// </summary>
    public partial class BrowseTrips : Window
    {
        Connection cnn = new Connection();
        public BrowseTrips()
        {
            InitializeComponent();
            tripsTable.DataContext=cnn.fillDataTable();
        }

        private void loadData_Click(object sender, RoutedEventArgs e)
        {
            tripsTable.DataContext = cnn.fillDataTable();
        }

        private void deleteData_Click(object sender, RoutedEventArgs e)
        {
            string selectedID = "";
            foreach (DataRowView row in tripsTable.SelectedItems)
            {
                System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                selectedID = MyRow["TripID"].ToString();
            }
            cnn.deleteTrip(selectedID);
            tripsTable.DataContext = cnn.fillDataTable();
        }

        private void tripsTable_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
    }
}
