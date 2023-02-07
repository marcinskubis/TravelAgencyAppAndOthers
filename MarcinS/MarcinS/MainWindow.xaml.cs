using MarcinS.Lista2;
using MarcinS.Lista3;
using MarcinS.Projekt;
using System.Windows;

namespace MarcinS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Lista1_Click(object sender, RoutedEventArgs e)
        {
            Window w = new Zadanie2();
            w.Show();
            Window w1 = new Zadanie3();
            w1.Show();
            Window w2 = new Zadanie4();
            w2.Show();
        }
        private void ChristmasPostcard_Click(object sender, RoutedEventArgs e)
        {
            Window w = new PostcardMainWIndow();
            w.Show();
        }
        private void Lista2_Click(object sender, RoutedEventArgs e)
        {
            Kalkulator w = new Kalkulator();
            w.Show();
        }
        private void Lista3_Click(object sender, RoutedEventArgs e)
        {
            Lista3MainWindow w = new Lista3MainWindow();
            w.Show();
        }
        private void Projekt_Click(object sender, RoutedEventArgs e)
        {
            ProjectMainWindow w = new ProjectMainWindow();
            w.Show();
        }
    }
}
