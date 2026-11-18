using System.Windows;

namespace Decorator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Validate(object sender, RoutedEventArgs e)
        {
            if (crepe.IsChecked == true)
            {
                // on veut une crepe
            }
            else if (waffle.IsChecked == true)
            {
                // on veut une gaufre
            }
            if (chocolate.IsChecked == true)
            {
                // supplément chocolat
            }
            if (sugar.IsChecked == true)
            {
                // supplément sucre
            }
        }
    }
}
