using System;
using System.Collections.Generic;
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

namespace MarcinS
{
    /// <summary>
    /// Interaction logic for Battleship1.xaml
    /// </summary>
    public partial class Battleship1 : Window
    {
        public Battleship1()
        {
            InitializeComponent();
            CrBttn();
        }

        private void CrBttn()
        {
            string letter = "";
            for(int i=1; i<11; i++)
            {
                for(int j=1; j<11; j++)
                {
                    switch(j)
                    {
                        case 1:
                            letter = "A";
                                break;
                        case 2:
                            letter = "B";
                                break;
                        case 3:
                            letter = "C";
                                break;
                        case 4:
                            letter = "D";
                                break;
                        case 5:
                            letter = "E";
                                break;
                        case 6:
                            letter = "F";
                                break;
                        case 7:
                            letter = "G";
                                break;
                        case 8:
                            letter = "H";
                                break;
                        case 9:
                            letter = "I";
                                break;
                        case 10:
                            letter = "J";
                                break;
                    }
                    Button button = new Button();
                    button.Tag = $"{letter}{i}";
                    Grid.SetColumn(button, i);
                    Grid.SetRow(button, j);
                    G1.Children.Add(button);

                }
            }
        }
    }
}
