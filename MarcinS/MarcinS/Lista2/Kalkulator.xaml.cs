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
using System.Windows.Shapes;

namespace MarcinS.Lista2
{
    /// <summary>
    /// Interaction logic for Kalkulator.xaml
    /// </summary>
    public partial class Kalkulator : Window
    {
        public Kalkulator()
        {
            InitializeComponent();
            input.Text = "0";
        }
        #region zmienne
        string lastOperation = "";
        double result = 0;
        bool operation_pressed = false;
        #endregion

        #region klawisze
        private void add_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                equ_Click(sender, e);
                lastOperation = "+";
                operation_pressed = true;
                result = Convert.ToDouble(input.Text);
                screen.Content = Convert.ToString(result) + lastOperation;
            }
            lastOperation = "+";
            operation_pressed = true;
            result = Convert.ToDouble(input.Text);
            screen.Content = Convert.ToString(result) + lastOperation;
        }
        private void sub_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                equ_Click(sender, e);
                lastOperation = "-";
                operation_pressed = true;
                result = Convert.ToDouble(input.Text);
                screen.Content = Convert.ToString(result) + lastOperation;
            }
            lastOperation = "-";
            operation_pressed = true;
            result = Convert.ToDouble(input.Text);
            screen.Content = Convert.ToString(result) + lastOperation;
        }
        private void mul_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                equ_Click(sender, e);
                lastOperation = "*";
                operation_pressed = true;
                result = Convert.ToDouble(input.Text);
                screen.Content = Convert.ToString(result) + lastOperation;
            }
            lastOperation = "*";
            operation_pressed = true;
            result = Convert.ToDouble(input.Text);
            screen.Content = Convert.ToString(result) + lastOperation;
        }
        private void div_Click(object sender, RoutedEventArgs e)
        {
            if (result != 0)
            {
                equ_Click(sender, e);
                lastOperation = "/";
                operation_pressed = true;
                result = Convert.ToDouble(input.Text);
                screen.Content = Convert.ToString(result) + lastOperation;
            }
            lastOperation = "/";
            operation_pressed = true;
            result = Convert.ToDouble(input.Text);
            screen.Content = Convert.ToString(result) + lastOperation;
        }
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            input.Text = "0";
            result = 0;
            screen.Content = "";
        }
        private void equ_Click(object sender, RoutedEventArgs e)
        {
            switch (lastOperation)
            {
                case "+":
                    input.Text = Convert.ToString(result + Convert.ToDouble(input.Text));
                    break;
                case "-":
                    input.Text = Convert.ToString(result - Convert.ToDouble(input.Text));
                    break;
                case "*":
                    input.Text = Convert.ToString(result * Convert.ToDouble(input.Text));
                    break;
                case "/":
                    input.Text = Convert.ToString(result / Convert.ToDouble(input.Text));
                    break;
                default:
                    break;
            }
            result = Convert.ToDouble(input.Text);
            screen.Content = result;
            lastOperation = "";
        }

        private void coma_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            else if (String.IsNullOrEmpty(input.Text))
            {
                input.Text = input.Text + "0";
            }
            if (!input.Text.Contains(","))
            {
                input.Text = input.Text + ",";
            }
            else
            {
                MessageBox.Show("Niedozwolona operacja");
            }
        }
        private void number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (operation_pressed || input.Text == $"0")
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + $"{btn.Content}";
        }
        #endregion
        private void input_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
