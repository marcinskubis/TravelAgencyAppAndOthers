using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MarcinS
{
    public class BattleshipLogic :Window
    { 
        public static void setButtonUpdate(Button button)
        {
            string tag = button.Tag.ToString() ?? string.Empty;
            int x = Convert.ToInt32(tag[1]);
            
            if(x == 0)
            {
                button.Background = new SolidColorBrush(Colors.Black);
                tag = "1" + string.Substring(1);
            }

        }



    }
}
