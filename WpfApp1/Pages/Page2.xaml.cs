using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Этот метод принимает введенные пользователем данные и выводит ответ
        /// </summary>
        /// <param name="sender">ссылка на кнопку</param>
        /// <param name="e">данные кнопки</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(x.Text, out float xx);
            float.TryParse(y.Text, out float yy);
            float.TryParse(z.Text, out float zz);

            Math1(xx, yy, zz);
        }
        /// <summary>
        /// Этот метод очищает поля ввода и вывода
        /// </summary>
        /// <param name="sender">ссылка на кнопку</param>
        /// <param name="e">данные кнопки</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            x.Text = String.Empty;
            y.Text = String.Empty;
            z.Text = String.Empty;
            answer.Text = String.Empty;
        }
        /// <summary>
        /// Этот метод переносит пользователя на Page3 с примером номер 2
        /// </summary>
        /// <param name="sender">ссылка на кнопку</param>
        /// <param name="e">данные кнопки</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        /// <summary>
        /// Этот метод переносит пользователя на Page1 на главную страницу
        /// </summary>
        /// <param name="sender">ссылка на кнопку</param>
        /// <param name="e">данные кнопки</param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        /// <summary>
        /// Этот метод вычисляет ответ
        /// </summary>
        /// <param name="xx">Переменная х в уравнении</param>
        /// <param name="yy">Переменная y в уравнении</param>
        /// <param name="zz">Переменная z в уравнении</param>
        /// <returns>Выводит true</returns>
        public bool Math1 (float xx, float yy, float zz)
        {
            Class1.otv = (float)(Pow(10 * (Pow(xx, 1 / 3) + Pow(xx, yy + 2)), 0.5) * (Pow(Asin(zz), 2) - Abs(xx - yy)));
            answer.Text = Convert.ToString(Class1.otv);
            return true;
        }
    }
}
