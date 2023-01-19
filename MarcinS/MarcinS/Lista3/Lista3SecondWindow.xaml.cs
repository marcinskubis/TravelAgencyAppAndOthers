using System.Windows;


namespace MarcinS.Lista3
{
    /// <summary>
    /// Interaction logic for Lista3SecondWindow.xaml
    /// </summary>
    public partial class Lista3SecondWindow : Window
    {
        public bool IsOkPressed { get; set; }
        public Lista3SecondWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsOkPressed = false;
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IsOkPressed = true;
            this.Close();
        }
    }
}
