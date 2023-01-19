using Microsoft.Data.SqlClient;
using System;
using System.Windows;


namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for AddTrip.xaml
    /// </summary>
    public partial class AddTrip : Window
    {
        public AddTrip()
        {
            InitializeComponent();
            fillListBox();
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MARCIN;Database=projekt;Integrated Security=True;Connect Timeout=30;
                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False";
                SqlConnection cnn1 = new SqlConnection(connectionString);
                cnn1.Open();
                SqlCommand cmd = new SqlCommand($"insert into Trips(Deparature, Destination, Price)\r\nvalues('{departure.Text}','{destination.SelectedItem}',{Convert.ToDouble(price.Text)});", cnn1);
                cmd.ExecuteNonQuery();
                cnn1.Close();
                ClearTextBoxes();
                MessageBox.Show("Pomyślnie dodano wycieczkę");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private void fillListBox()
        {
            try
            {
                string connectionString = @"Data Source=MARCIN;Database=projekt;Integrated Security=True;Connect Timeout=30;
                Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                MultiSubnetFailover=False";
                SqlConnection cnn1 = new SqlConnection(connectionString);
                cnn1.Open();
                SqlCommand cmd = new SqlCommand($"select * from Destinations", cnn1);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    destination.Items.Add(rd["Name"]);
                }
                cnn1.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private void ClearTextBoxes()
        {
            departure.Text = string.Empty;
            destination.SelectedItem = null;
            price.Text = string.Empty;
        }
    }
}
