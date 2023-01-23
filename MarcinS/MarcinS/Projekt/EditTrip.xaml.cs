using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for EditTrip.xaml
    /// </summary>
    public partial class EditTrip : BrowseTrips
    {
        BrowseTrips browse = new BrowseTrips();
        public EditTrip()
        {
            InitializeComponent();
            string txt = date.SelectedDate.Value.Date.ToString("yyyy-MM-dd");
            departure.Text = getDataFromDataGrid("Wylot");
            destination.Text = getDataFromDataGrid("Przylot");
            price.Text = getDataFromDataGrid("Cena");
            length.Text = getDataFromDataGrid("Ilość dni");
            date.DisplayDate = getDateFromDataGrid();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedID = null;
            if (browse.tripsTable.SelectedIndex >= 0)
            {
                DataRowView castedRow = browse.tripsTable.SelectedItems[0] as DataRowView;
                if (castedRow != null)
                {

                    foreach (DataRowView row in browse.tripsTable.SelectedItems)
                    {
                        System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                        selectedID = MyRow["TripID"].ToString();
                    }
                }
            }
        }
        private string getDataFromDataGrid(string column)
        {
            string x = null;
            if (browse.tripsTable.SelectedIndex >= 0)
            {
                DataRowView castedRow = browse.tripsTable.SelectedItems[0] as DataRowView;
                if (castedRow != null)
                {

                    foreach (DataRowView row in browse.tripsTable.SelectedItems)
                    {
                        System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                        x = MyRow[$"{column}"].ToString();
                    }
                }
            }
            return x;
        }
        private DateTime getDateFromDataGrid()
        {
            DateTime x = DateTime.Now;
            if (browse.tripsTable.SelectedIndex >= 0)
            {
                DataRowView castedRow = browse.tripsTable.SelectedItems[0] as DataRowView;
                if (castedRow != null)
                {

                    foreach (DataRowView row in browse.tripsTable.SelectedItems)
                    {
                        System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                        x = Convert.ToDateTime(MyRow[$"Data"]);
                    }
                }
            }
            return x;
        }
    }
}
