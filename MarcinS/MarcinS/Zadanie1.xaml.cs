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
        #region zmienne
        string lastOperation = "";
        int result = 0;
        bool operation_pressed = false;

        #endregion

        #region klawisze
        

        
        private void add_Click(object sender, RoutedEventArgs e)
        {
            lastOperation="+";
            result = Convert.ToInt32(input.Text);
            operation_pressed = true;
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            lastOperation="-";
            result = Convert.ToInt32(input.Text);
            operation_pressed = true;
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            lastOperation="*";
            result = Convert.ToInt32(input.Text);
            operation_pressed = true;
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            lastOperation="/";
            result = Convert.ToInt32(input.Text);
            operation_pressed = true;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            input.Text = "";
        }

        private void equ_Click(object sender, RoutedEventArgs e)
        {
            switch (lastOperation)
            {
                case"+":
                    input.Text = Convert.ToString(result + Convert.ToInt32(input.Text));
                    break;
                case "-":
                    input.Text = Convert.ToString(result - Convert.ToInt32(input.Text));
                    break;
                case "*":
                    input.Text = Convert.ToString(result * Convert.ToInt32(input.Text));
                    break;
                case "/":
                    input.Text = Convert.ToString(result / Convert.ToInt32(input.Text));
                    break;
                default:
                    break;
            }
            
        }

        private void zerzer_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "00";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "1";
            
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "4";
            
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "7";
            
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {

            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "2";
            
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "5";
            
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "8";
            
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "0";
            
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "3";
            
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "6";
            
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (operation_pressed)
            {
                input.Clear();
            }
            operation_pressed = false;
            input.Text = input.Text + "9";
            
        }
        #endregion

        private void input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void input_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void coma_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
