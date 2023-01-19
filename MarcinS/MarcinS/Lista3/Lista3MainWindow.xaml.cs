using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace MarcinS.Lista3
{
    /// <summary>
    /// Interaction logic for Lista3MainWindow.xaml
    /// </summary>
    public partial class Lista3MainWindow : Window
    {
        List<Person> listofPersons = new List<Person>();
        public Lista3MainWindow()
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
            Lista3SecondWindow window = new Lista3SecondWindow();
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
