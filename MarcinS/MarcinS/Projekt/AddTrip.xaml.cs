using Microsoft.Data.SqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for AddTrip.xaml
    /// </summary>
    public partial class AddTrip : Window
    {
        Connection connection = new Connection();
        public AddTrip()
        {
            InitializeComponent();
            fillListBox();
        }
        public void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string txt = date.SelectedDate.Value.Date.ToString("yyyy-MM-dd");
                connection.addTripF(departure.Text,connection.getIdByName((string)destination.SelectedItem),price.Text,length.Text,txt,hotel.Text);
                ClearTextBoxes();
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private void ClearTextBoxes()
        {
            departure.Text = string.Empty;
            destination.SelectedItem = null;
            price.Text = string.Empty;
            hotel.Text = string.Empty;
            length.Text = string.Empty;
            date.SelectedDate = DateTime.Today;
        }
        public void fillListBox()
        {
            connection.fillComboBox(destination);
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
