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
using static System.Math;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Text = Convert.ToString(Class1.otv);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b.Text = String.Empty;
            x.Text = String.Empty;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            float.TryParse(b.Text, out float bb);
            float.TryParse(x.Text, out float xx);

            if (0.5 < xx * bb && xx * bb < 10)
            {
                Class1.otv = (float)Exp(Sinh(xx) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                Class1.otv = (float)Pow(Abs(Sinh(xx) + bb), 0.5);
            }
            else
            {
                Class1.otv = (float)(2 * Pow(Sinh(xx), 2));
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            float.TryParse(b.Text, out float bb);
            float.TryParse(x.Text, out float xx);

            if (0.5 < xx * bb && xx * bb < 10)
            {
                Class1.otv = (float)Exp(Pow(xx, 2) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                Class1.otv = (float)Pow(Abs(Pow(xx, 2) + bb), 0.5);
            }
            else
            {
                Class1.otv = (float)(2 * Pow(Pow(xx, 2), 2));
            }
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            float.TryParse(b.Text, out float bb);
            float.TryParse(x.Text, out float xx);

            if (0.5 < xx * bb && xx * bb < 10)
            {
                Class1.otv = (float)Exp(Exp(xx) - Abs(bb));
            }
            else if (0.1 < xx * bb && xx * bb < 0.5)
            {
                Class1.otv = (float)Pow(Abs(Exp(xx) + bb), 0.5);
            }
            else
            {
                Class1.otv = (float)(2 * Pow(Exp(xx), 2));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
