using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarcinS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        #region klawisze
        private void add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            input.Text=input.Text+"1";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "4";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "7";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "2";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "5";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "8";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "0";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "3";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "6";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            input.Text = input.Text + "9";

        }
        #endregion

        #region funckje



        #endregion

        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void input_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
