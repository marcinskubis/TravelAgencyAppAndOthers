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
    public partial class EditTrip : Window
    {
        Trip trip = new Trip();
        Connection cnn = new Connection();
        int id = 0;
        Trip trip1 = new Trip();
        public EditTrip(Trip trip)
        {
            InitializeComponent();
            this.trip = trip;
            departure.Text=trip.Wylot.ToString();
            price.Text=trip.Cena.ToString();
            hotel.Text=trip.Hotel.ToString();
            date.SelectedDate=Convert.ToDateTime(trip.Data);
            length.Text=trip.Dni.ToString();
            cnn.fillComboBox(destination);
            destination.SelectedItem = trip.Przylot.ToString();
            id = Convert.ToInt32(trip.TripID);
            trip1 = trip;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            string txt = date.SelectedDate.Value.Date.ToString("yyyy-MM-dd");
            trip.Cena = Convert.ToInt32(price.Text);
            trip.Wylot = departure.Text;
            trip.Hotel = hotel.Text;
            trip.Przylot= destination.SelectedItem.ToString();
            trip.Dni = length.Text;
            trip.Data = date.SelectedDate.Value.Date;
            int destinationid = cnn.getIdByName(trip.Przylot.ToString());
            cnn.changeRow(id, destinationid,trip.Wylot.ToString(), trip.Cena.ToString(), trip.Dni.ToString(), trip.Hotel.ToString(), txt);
            cnn.fillDataTable();
            this.Close();
        }


        private bool checkIfChanged(Trip orTrip, Trip chTrip)
        {
            if(orTrip.Cena.Equals(chTrip.Cena) || orTrip.Hotel.Equals(chTrip.Hotel)
                || orTrip.Wylot.Equals(chTrip.Wylot) || orTrip.Dni.Equals(chTrip.Dni)
                || orTrip.Przylot.Equals(chTrip.Przylot)|| orTrip.Data.Equals(chTrip.Data)) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
