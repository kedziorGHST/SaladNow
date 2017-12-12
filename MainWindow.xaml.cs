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
using System.Windows.Input;

namespace SaladNOW
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double price = 0;
        double priceAfterMul = 0;
        double multiple = 0;
        /// <summary>
        /// Utworzenie obiektów warzywa
        /// </summary>
        Vege cucumber = new Vege(1, 0.5, "Ogórek",  14, 0.1, 0, 11, 125, 3, 0.7); 
        Vege pepper = new Vege(2, 1, "Papryka", 28, 1, 0, 7, 340, 9, 2);
        Vege tomato = new Vege(3, 0.7, "Pomidor", 17, 0.2, 0, 5, 237, 3.9, 0.9);
        Vege onion = new Vege(4, 0.5, "Cebula", 39, 0.1, 0, 4, 146, 9, 1.1);
        Vege corn = new Vege(5, 0.5, "Kukurydza", 365, 4.7, 0, 35, 287, 74, 9);
        Vege chicken = new Vege(6, 3, "Kurczak", 234, 4, 0, 393, 212, 0.06, 27);
        Vege broccoli = new Vege(7, 0.7, "Brokuł", 33, 0.4, 0, 33, 316, 7, 2.8);
        Vege salad = new Vege(8, 0.5, "Sałata", 14, 0.2, 0, 28, 194, 2.9, 1.4);
        Vege olives = new Vege(9, 0.5, "Oliwki", 115, 11, 0, 735, 8, 6, 0.8);


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCucumber_Click(object sender, RoutedEventArgs e)
        {
            if (btnCucumber.BorderBrush == Brushes.Red)
            {
                btnCucumber.BorderBrush = Brushes.Transparent;
                price -= cucumber.price;
            }
            else
            {
                btnCucumber.BorderBrush = Brushes.Red;
                price += cucumber.price;
            }
        }

        private void btnPepper_Click(object sender, RoutedEventArgs e)
        {
            if (btnPepper.BorderBrush == Brushes.Red)
            {
                btnPepper.BorderBrush = Brushes.Transparent;
                price -= pepper.price;
            }
            else
            {
                btnPepper.BorderBrush = Brushes.Red;
                price += pepper.price;
            }
        }

        private void btnTomato_Click(object sender, RoutedEventArgs e)
        {
            if (btnTomato.BorderBrush == Brushes.Red)
            {
                btnTomato.BorderBrush = Brushes.Transparent;
                price -= tomato.price;
            }
            else
            {
                btnTomato.BorderBrush = Brushes.Red;
                price += tomato.price;
            }
        }

        private void btnOnion_Click(object sender, RoutedEventArgs e)
        {
            if (btnOnion.BorderBrush == Brushes.Red)
            {
                btnOnion.BorderBrush = Brushes.Transparent;
                price -= onion.price;
            }
            else
            {
                btnOnion.BorderBrush = Brushes.Red;
                price += onion.price;
            }
        }

        private void btnCorn_Click(object sender, RoutedEventArgs e)
        {
            if (btnCorn.BorderBrush == Brushes.Red)
            {
                btnCorn.BorderBrush = Brushes.Transparent;
                price -= corn.price;
            }
            else
            {
                btnCorn.BorderBrush = Brushes.Red;
                price += corn.price;
            }
        }

        private void btnChicken_Click(object sender, RoutedEventArgs e)
        {
            if (btnChicken.BorderBrush == Brushes.Red)
            {
                btnChicken.BorderBrush = Brushes.Transparent;
                price -= chicken.price;
            }
            else
            {
                btnChicken.BorderBrush = Brushes.Red;
                price += chicken.price;
            }
        }

        private void btnBroccoli_Click(object sender, RoutedEventArgs e)
        {
            if (btnBroccoli.BorderBrush == Brushes.Red)
            {
                btnBroccoli.BorderBrush = Brushes.Transparent;
                price -= broccoli.price;
            }
            else
            {
                btnBroccoli.BorderBrush = Brushes.Red;
                price += broccoli.price;
            }
        }

        private void btnSalad_Click(object sender, RoutedEventArgs e)
        {
            if (btnSalad.BorderBrush == Brushes.Red)
            {
                btnSalad.BorderBrush = Brushes.Transparent;
                price -= salad.price;
            }
            else
            {
                btnSalad.BorderBrush = Brushes.Red;
                price += salad.price;
            }
        }

        private void btnOlives_Click(object sender, RoutedEventArgs e)
        {
            if (btnOlives.BorderBrush == Brushes.Red)
            {
                btnOlives.BorderBrush = Brushes.Transparent;
                price -= olives.price;
            }
            else
            {
                btnOlives.BorderBrush = Brushes.Red;
                price += olives.price;
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
            if (price == 0)
            {
                MessageBox.Show("Nie wybrano żadnego produktu z listy.","Uwaga!");
                txtPrice.Text = "";
            }else
            {
                lblMessage.Content = "";
                priceAfterMul = multiple * price;
                txtPrice.Text = Convert.ToString(priceAfterMul);
            }
        }
    }
}
