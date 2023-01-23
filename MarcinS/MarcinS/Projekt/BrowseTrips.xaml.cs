using System.Data;
using System.Windows;
using System.Collections;
using System.Collections.Generic;

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
            string selectedID = null;
            if(tripsTable.SelectedIndex>=0)
            {
                DataRowView castedRow = tripsTable.SelectedItems[0] as DataRowView;
                if (castedRow != null) {

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
            Window wwindow = new EditTrip();
            wwindow.Show();

        }
    }
}
