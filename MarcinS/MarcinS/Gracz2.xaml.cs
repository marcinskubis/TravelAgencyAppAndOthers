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
using static MarcinS.Battleship1;

namespace MarcinS
{
    /// <summary>
    /// Interaction logic for Battleship2.xaml
    /// </summary>
    public partial class Battleship2 : Window
    {
        public Battleship2()
        {
            InitializeComponent();
            CrBtn();
        }

        void setButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (((BattleshipLogic)G1.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())] == 0)
                ((BattleshipLogic)G1.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())]++;
            else if (((BattleshipLogic)G1.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())] == 1)
                ((BattleshipLogic)G1.DataContext).PersonIdTwo[Convert.ToInt32(btn.Tag.ToString())]--;
        }

        void shootButton_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (((BattleshipLogic)G1.DataContext).PersonIdOne[Convert.ToInt32(btn.Tag.ToString())] == 0 || ((BattleshipLogic)G1.DataContext).PersonIdOne[Convert.ToInt32(btn.Tag.ToString())] == 1)
                ((BattleshipLogic)G1.DataContext).PersonIdOne[Convert.ToInt32(btn.Tag.ToString())] += 2;
        }

        public void CrBtn()
        {
            int x = 0;
            int y = 0;
            for (int k = 0; k < 2; k++)
            {
                switch (k) { 
                    //strzelanie
                    case 0:
                        for (int i = 1; i < 11; i++)
                        {
                            for (int j = 1; j < 11; j++)
                            {
                                Button button = new Button();
                                button.Tag = $"{x}";
                                Grid.SetColumn(button, i);
                                Grid.SetRow(button, j);
                                shoot.Children.Add(button);
                                button.Click += new RoutedEventHandler(shootButton_Click);
                                YesNoToBooleanConverter2 yesNoToBooleanConverter2 = new YesNoToBooleanConverter2();
                                Binding bind = new Binding
                                {
                                    Path = new PropertyPath(Convert.ToString($"PersonIdOne[{x}]")),
                                    Mode = BindingMode.TwoWay,
                                    Converter = yesNoToBooleanConverter2,
                                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                                };
                                button.SetBinding(Button.BackgroundProperty, bind);
                                x++;

                            }
                        }
                        break;
                    //stawianie  
                    case 1:
                        for (int i = 1; i < 11; i++)
                        {
                            for (int j = 1; j < 11; j++)
                            {
                                   
                                Button button = new Button();
                                button.Tag = $"{y}";
                                Grid.SetColumn(button, i);
                                Grid.SetRow(button, j);
                                set.Children.Add(button);
                                button.Click += new RoutedEventHandler(setButton_Click);
                                YesNoToBooleanConverter yesNoToBooleanConverter = new YesNoToBooleanConverter();
                                Binding bind = new Binding
                                {
                                    Path = new PropertyPath(Convert.ToString($"PersonIdTwo[{y}]")),
                                    Mode = BindingMode.TwoWay,
                                    Converter = yesNoToBooleanConverter,
                                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                                };
                                button.SetBinding(Button.BackgroundProperty, bind);
                                y++;

                            }
                        }
                        break;
                }
            }

        }
    }
}
