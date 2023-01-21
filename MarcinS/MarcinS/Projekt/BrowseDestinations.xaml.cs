using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
            string imageName = "";
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
    }
}
