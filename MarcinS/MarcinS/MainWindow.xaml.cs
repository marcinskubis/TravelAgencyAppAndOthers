using MarcinS.Lista2;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
    }
}
