using System.Windows;
namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for ProjectMainWindow.xaml
    /// </summary>
    public partial class ProjectMainWindow : Window
    {
        public ProjectMainWindow()
        {
            InitializeComponent();
        }
        private void AddTrip_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AddTrip();
            window.ShowDialog();

        }
        private void Trip_Click(object sender, RoutedEventArgs e)
        {
            Window window = new BrowseTrips();
            window.ShowDialog();
        }

        private void BrowseDestinations_Click(object sender, RoutedEventArgs e)
        {
            Window window = new BrowseDestinations();
            window.ShowDialog();
        }

        private void AddDestination_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AddDestination();
            window.ShowDialog();
        }
    }
}
