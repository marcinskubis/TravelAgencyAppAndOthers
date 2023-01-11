using System.Windows;

namespace MarcinS
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void calculatorClick(object sender, RoutedEventArgs e)
        {
            MainWindow zad1 = new MainWindow();
            zad1.Show();
        }

        private void kikClick(object sender, RoutedEventArgs e)
        {
            Kik kik=new Kik();
            kik.Show();
        }

        private void shipsClick(object sender, RoutedEventArgs e)
        {
            Battleship1 battleship1 = new Battleship1();
            battleship1.Show();
        }
    }
}
