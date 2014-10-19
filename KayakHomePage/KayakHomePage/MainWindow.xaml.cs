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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KayakHomePage
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

        private void oneWay_MouseDown(object sender, RoutedEventArgs e)
        {
            oneWay.Foreground = Brushes.Black;
            roundTrip.Foreground = Brushes.LightGray;
        }

        private void roundTrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            oneWay.Foreground = (SolidColorBrush)(new BrushConverter().ConvertFrom("#b7b7b7"));
            roundTrip.Foreground = Brushes.Black;
        }

    }
}
