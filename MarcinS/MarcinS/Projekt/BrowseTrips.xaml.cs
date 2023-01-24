using System.Data;
using System.Windows;
using System.Collections;
using System.Collections.Generic;
using System;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using System.Data.Common;

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
            tripsTable.DataContext = cnn.fillDataTable();
        }

        private void loadData_Click(object sender, RoutedEventArgs e)
        {
            tripsTable.DataContext = cnn.fillDataTable();
        }

        private void deleteData_Click(object sender, RoutedEventArgs e)
        {
            string selectedID = null;
            if (tripsTable.SelectedIndex >= 0)
            {
                DataRowView castedRow = tripsTable.SelectedItems[0] as DataRowView;
                if (castedRow != null)
                {

                    foreach (DataRowView row in tripsTable.SelectedItems)
                    {
                        System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                        selectedID = MyRow["TripID"].ToString();
                    }
                }
                if (selectedID != null)
                {
                    cnn.deleteTrip(selectedID);
                    //tripsTable.DataContext = cnn.fillDataTable();
                    DataRowView drv = tripsTable.SelectedItem as DataRowView;
                    if (drv != null)
                    {
                        DataView dataView = tripsTable.ItemsSource as DataView;
                        dataView.Table.Rows.Remove(drv.Row);
                    }
                }
                else
                {
                    MessageBox.Show("Wybierz poprawną pozycję.");
                }
            }
            else
            {
                MessageBox.Show("Wybierz poprawną pozycję.");
            }
        }

        private void editData_Click(object sender, RoutedEventArgs e)
        {
            Trip trip = new Trip();
            trip.TripID = getData("TripID");
            trip.Hotel = getData("Hotel");
            trip.Wylot = getData("Wylot");
            trip.Dni = getData("Dni");
            trip.Cena = getData("Cena");
            trip.Przylot = getData("Przylot");
            trip.Data = getDate();
            trip.list.Add(trip);
            MessageBox.Show(trip.Data.ToString());
            EditTrip ed = new EditTrip(trip);
            ed.Show();
        }

        private string getData(string column)
        {
            string x=null;
            if (tripsTable.SelectedIndex >= 0)
            {
                DataRowView castedRow = tripsTable.SelectedItems[0] as DataRowView;
                if (castedRow != null)
                {

                    foreach (DataRowView row in tripsTable.SelectedItems)
                    {
                        System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                        x = MyRow[$"{column}"].ToString();

                    }
                }
            }
            return x;
        }

        private DateTime getDate()
        {
            DateTime x=DateTime.Today;
            if (tripsTable.SelectedIndex >= 0)
            {
                DataRowView castedRow = tripsTable.SelectedItems[0] as DataRowView;
                if (castedRow != null)
                {

                    foreach (DataRowView row in tripsTable.SelectedItems)
                    {
                        System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                        x = Convert.ToDateTime(MyRow[$"Data"].ToString());

                    }
                }
            }
            return x;
        }
    }

}
