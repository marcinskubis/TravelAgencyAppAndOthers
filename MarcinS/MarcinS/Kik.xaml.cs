using System;
using System.Windows;
using System.Windows.Controls;

namespace MarcinS
{
    /// <summary>
    /// Interaction logic for Kik.xaml
    /// </summary>
    public partial class Kik : Window
    {
        public Kik()
        {
            InitializeComponent();
        }

        KikLogic KikLogic = new KikLogic();
        int x = 0;
        int y = 0;

        private void PlayerClick(object sender, RoutedEventArgs e)
        {
            var space = (Button)sender;
            if (!String.IsNullOrWhiteSpace(space.ContentStringFormat)) {
                return;
             }
            space.Content =KikLogic.CurrentPlayer;

            string coordinates = space.Tag.ToString() ?? string.Empty;
            x = Convert.ToInt32(coordinates[0].ToString());
            y = Convert.ToInt32(coordinates[1].ToString());

            KikLogic.UpdateBoard(x, y, KikLogic.CurrentPlayer);

            if (KikLogic.Win())
            {
                MessageBox.Show($"{KikLogic.CurrentPlayer} wins");
                KikLogic = new KikLogic();
            }

            KikLogic.NextPlayer();
        }


        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            foreach(var control in Board.Children)
            {
                if(control is Button)
                {
                    ((Button)control).Content = String.Empty;
                }
            }
            NewGame.Content = "New Game"; 
            KikLogic = new KikLogic();
        }
    }
}
