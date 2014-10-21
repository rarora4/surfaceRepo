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

namespace Kayak_Page3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            chkboxStop.Visibility = Visibility.Hidden;
            chkboxAirlines.Visibility = Visibility.Hidden;
            chkboxPrice.Visibility = Visibility.Hidden;
            chkboxDeparture.Visibility = Visibility.Hidden;
            chkboxReturn.Visibility = Visibility.Hidden;
        }


        private void btnStops_Click(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
            if (chkboxStop.Visibility == Visibility.Hidden)
            {
                chkboxStop.Visibility = Visibility.Visible;
            }
            else {
                chkboxStop.Visibility = Visibility.Hidden;
            }            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
        }

        private void btnAirlines_Click(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
            if (chkboxAirlines.Visibility == Visibility.Hidden)
            {
                chkboxAirlines.Visibility = Visibility.Visible;
            }
            else
            {
                chkboxAirlines.Visibility = Visibility.Hidden;
            }         
        }

        private void btnPrice_Click(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
            if (chkboxPrice.Visibility == Visibility.Hidden)
            {
                chkboxPrice.Visibility = Visibility.Visible;
            }
            else
            {
                chkboxPrice.Visibility = Visibility.Hidden;
            }         
        }

        private void btnDeparture_Click(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
            if (chkboxDeparture.Visibility == Visibility.Hidden)
            {
                chkboxDeparture.Visibility = Visibility.Visible;
            }
            else
            {
                chkboxDeparture.Visibility = Visibility.Hidden;
            }    

        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
            if (chkboxReturn.Visibility == Visibility.Hidden)
            {
                chkboxReturn.Visibility = Visibility.Visible;
            }
            else
            {
                chkboxReturn.Visibility = Visibility.Hidden;
            }  
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            Window_MouseLeftButtonDown(sender, e);
        }
        private void Window_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            if (chkboxStop.Visibility != Visibility.Hidden)
            {
                chkboxStop.Visibility = Visibility.Hidden;
            }
            if (chkboxAirlines.Visibility != Visibility.Hidden)
            {
                chkboxAirlines.Visibility = Visibility.Hidden;
            }
            if (chkboxPrice.Visibility != Visibility.Hidden)
            {
                chkboxPrice.Visibility = Visibility.Hidden;
            }
            if (chkboxDeparture.Visibility != Visibility.Hidden)
            {
                chkboxDeparture.Visibility = Visibility.Hidden;
            }
            if (chkboxReturn.Visibility != Visibility.Hidden)
            {
                chkboxReturn.Visibility = Visibility.Hidden;
            }    
        }
    }
}
