using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace MarcinS.Projekt
{
    /// <summary>
    /// Interaction logic for AddDestination.xaml
    /// </summary>
    public partial class AddDestination : Window
    {
        Connection cnn = new Connection();
        public AddDestination()
        {
            InitializeComponent();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void addDestination_Click(object sender, RoutedEventArgs e)
        {
            cnn.addDestination(name.Text,country.Text,population.Text);
            clearTextBoxes();
        }
        private void clearTextBoxes()
        {
            name.Text= string.Empty;
            country.Text= string.Empty;
            population.Text= string.Empty;
        }
    }
}
