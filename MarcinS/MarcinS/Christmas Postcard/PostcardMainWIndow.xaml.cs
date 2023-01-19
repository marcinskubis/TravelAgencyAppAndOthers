using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Logika interakcji dla klasy PostcardMainWIndow.xaml
    /// </summary>
    public partial class PostcardMainWIndow : Window
    {
        public PostcardMainWIndow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(MarcinS.Resources.sound);
            player.Play();
            MessageBox.Show($"Wszystkiego najlepszego od {OD.Text} dla {DO.Text}");
        }
    }
}
