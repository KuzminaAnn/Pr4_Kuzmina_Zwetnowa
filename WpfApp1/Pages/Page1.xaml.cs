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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Этот метод переносит пользователя на Page2 с примером номер 1
        /// </summary>
        /// <param name="sender">ссылка на кнопку</param>
        /// <param name="e">данные кнопки</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        /// <summary>
        /// Этот метод переносит пользователя на Page3 с примером номер 2
        /// </summary>
        /// <param name="sender">ссылка на кнопку</param>
        /// <param name="e">данные кнопки</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        /// <summary>
        /// Этот метод переносит пользователя на Page4 с примером номер 3
        /// </summary>
        /// <param name="sender">ссылка на кнопку</param>
        /// <param name="e">данные кнопки</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
