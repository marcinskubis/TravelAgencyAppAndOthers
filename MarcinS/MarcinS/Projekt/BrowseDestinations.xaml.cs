using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for BrowseDestinations.xaml
    /// </summary>
    public partial class BrowseDestinations : Window
    {
        Connection cnn = new Connection();
        public BrowseDestinations()
        {
            InitializeComponent();
            destinations.DataContext = cnn.fillDestinationTable();
        }
        private void destinations_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            DataRowView castedRow = destinations.SelectedItems[0] as DataRowView;
            if (castedRow!=null)
            {
                string imageName = null;
                BitmapImage btm = new BitmapImage();
                foreach (DataRowView row in destinations.SelectedItems)
                {
                    System.Data.DataRow MyRow = (System.Data.DataRow)row.Row;
                    imageName = MyRow["Name"].ToString();
                }
                btm.BeginInit();
                btm.UriSource = new Uri($"pack://application:,,,/Resources/{imageName}.jpg");
                btm.EndInit();
                image.Source = btm;
            }
            else
            {
                MessageBox.Show("Wybierz poprawną pozycję.");
            }
        }
    }
}
