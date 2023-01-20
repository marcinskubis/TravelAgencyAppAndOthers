using Microsoft.Data.SqlClient;
using System.Data;
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
        public BrowseTrips()
        {
            InitializeComponent();
            loadDataF();
        }

        private void loadData_Click(object sender, RoutedEventArgs e)
        {
            loadDataF();
        }

        private void deleteData_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void loadDataF()
        {
            string connectionString = @"Data Source=MARCIN;Database=projekt;Integrated Security=True;Connect Timeout=30;
            Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False";
            SqlConnection cnn1 = new SqlConnection(connectionString);
            cnn1.Open();
            SqlCommand cmd = new SqlCommand("select * from Trips", cnn1);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            cmd.Dispose();
            cnn1.Close();
            tripsTable.ItemsSource = dt.DefaultView;
        }
    }
}
