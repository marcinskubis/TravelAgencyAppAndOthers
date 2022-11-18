using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;


namespace MarcinS
{
    public partial class MainWindow : Window
    {
        List<Person> listofPersons = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("C://test.xml"))
            {
                listofPersons = Serialization.DeserializeToObject<List<Person>>("C://test.xml");  
            }
            else
            {
                listofPersons.Add(new Person("2137", "Andrzej", "Nowak", "13"));
                listofPersons.Add(new Person("2137", "Andrzej", "Nowak", "13"));
                listofPersons.Add(new Person("2137", "Andrzej", "Nowak", "13"));
                listofPersons.Add(new Person("2137", "Andrzej", "Nowak", "13"));
            }
            dataGridPerson.ItemsSource = listofPersons;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            Person person = new Person();
            window.DataContext = person;
            window.ShowDialog();
            if (window.IsOkPressed)
            {
                listofPersons.Add(person);
                dataGridPerson.Items.Refresh();
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Serialization.SerializeToXml<List<Person>>(listofPersons, "C://test.xml");
        }
    }
}
