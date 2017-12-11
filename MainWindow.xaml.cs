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

namespace SaladNOW
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double price = 0;
        double multiple = 0;
        double cucumber = 0;
        double pepper = 0;
        double tomato = 0;
        double onion = 0;
        double corn = 0;
        double chicken = 0;
        double broccoli = 0;
        double salad = 0;
        double olives = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCucumber_Click(object sender, RoutedEventArgs e)
        {
            if (btnCucumber.BorderBrush == Brushes.Transparent)
            {
                btnCucumber.BorderBrush = Brushes.Red;
                cucumber = 1;
            }
            else
            {
                btnCucumber.BorderBrush = Brushes.Transparent;
                cucumber = 0;
            }
        }

        private void btnPepper_Click(object sender, RoutedEventArgs e)
        {
            if (btnPepper.BorderBrush == Brushes.Transparent)
            {
                btnPepper.BorderBrush = Brushes.Red;
                pepper = 1.5;
            }
            else
            {
                btnPepper.BorderBrush = Brushes.Transparent;
                pepper = 0;
            }
        }

        private void btnTomato_Click(object sender, RoutedEventArgs e)
        {
            if (btnTomato.BorderBrush == Brushes.Transparent)
            {
                btnTomato.BorderBrush = Brushes.Red;
                tomato = 0.9;
            }
            else
            {
                btnTomato.BorderBrush = Brushes.Transparent;
                tomato = 0;
            }
        }

        private void btnOnion_Click(object sender, RoutedEventArgs e)
        {
            if (btnOnion.BorderBrush == Brushes.Transparent)
            {
                btnOnion.BorderBrush = Brushes.Red;
                onion = 0.5;
            }
            else
            {
                btnOnion.BorderBrush = Brushes.Transparent;
                onion = 0;
            }
        }

        private void btnCorn_Click(object sender, RoutedEventArgs e)
        {
            if (btnCorn.BorderBrush == Brushes.Transparent)
            {
                btnCorn.BorderBrush = Brushes.Red;
                corn = 0.4;
            }
            else
            {
                btnCorn.BorderBrush = Brushes.Transparent;
                corn = 0;            
            }
        }

        private void btnChicken_Click(object sender, RoutedEventArgs e)
        {
            if (btnChicken.BorderBrush == Brushes.Transparent)
            {
                btnChicken.BorderBrush = Brushes.Red;
                chicken = 2.5;
            }
            else
            {
                btnChicken.BorderBrush = Brushes.Transparent;
                chicken = 0;
            }
        }

        private void btnBroccoli_Click(object sender, RoutedEventArgs e)
        {
            if (btnBroccoli.BorderBrush == Brushes.Transparent)
            {
                btnBroccoli.BorderBrush = Brushes.Red;
                broccoli = 1.7;
            }
            else
            {
                btnBroccoli.BorderBrush = Brushes.Transparent;
                broccoli = 0;
            }
        }

        private void btnSalad_Click(object sender, RoutedEventArgs e)
        {
            if (btnSalad.BorderBrush == Brushes.Transparent)
            {
                btnSalad.BorderBrush = Brushes.Red;
                salad = 0.6;
            }
            else
            {
                btnSalad.BorderBrush = Brushes.Transparent;
                salad = 0;
            }
        }

        private void btnOlives_Click(object sender, RoutedEventArgs e)
        {
            if (btnOlives.BorderBrush == Brushes.Transparent)
            {
                btnOlives.BorderBrush = Brushes.Red;
                olives = 2;
            }
            else
            {
                btnOlives.BorderBrush = Brushes.Transparent;
                olives = 0;
            }
        }

        private void rb100_Checked(object sender, RoutedEventArgs e)
        {
            multiple = 1;
        }

        private void rb200_Checked(object sender, RoutedEventArgs e)
        {
            multiple = 2;
        }

        private void rb300_Checked(object sender, RoutedEventArgs e)
        {
            multiple = 3;
        }

        private void btnCollect_Click(object sender, RoutedEventArgs e)
        {
            price = multiple * (cucumber + pepper + tomato + onion + corn + chicken + broccoli + salad + olives);
            txtPrice.Text = Convert.ToString(price);
        }
    }
}
