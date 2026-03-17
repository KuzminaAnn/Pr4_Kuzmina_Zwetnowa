using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Math;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private SeriesChartType currentType; //new
        List<Point> points = new List<Point>();
        List<float> a = new List<float>();
        public Page4()
        {
            InitializeComponent();
            
            ChartPayments.ChartAreas.Add(new ChartArea("Main"));
            var currentSeries = new Series("График");
            currentSeries.Points.Clear();

            currentType = SeriesChartType.Line; //new
            ChartPayments.Series.Add(currentSeries);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float.TryParse(x0.Text, out float xx0);
            float.TryParse(xk.Text, out float xxk);
            float.TryParse(dx.Text, out float dxx);
            float.TryParse(d.Text, out float dd);

            Math3(xx0, xxk, dxx, dd);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            x0.Text = String.Empty;
            xk.Text = String.Empty;
            dx.Text = String.Empty;
            d.Text = String.Empty;
            answer.Text = String.Empty;
            points.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        public bool Math3(float xx0, float xxk, float dxx, float dd)
        {
            Series currentSeries = ChartPayments.Series.FirstOrDefault();
            currentSeries.ChartType = SeriesChartType.Line;
            if (xx0 <= xxk)
            {
                while (xx0 <= xxk)
                {
                    Class1.otv = (float)(Pow(xx0, 2) + Tan(5 * xx0 + (dd / xx0)));
                    a.Add(Class1.otv);
                    points.Add(new Point(xx0, Class1.otv));
                    xx0 += dxx;
                    currentSeries.Points.Clear();
                }
                ;
            }
            else
            {
                while (xxk >= xx0)
                {
                    Class1.otv = (float)(Pow(xx0, 2) + Tan(5 * xx0 + (dd / xx0)));
                    a.Add(Class1.otv);
                    points.Add(new Point(xxk, Class1.otv));
                    xxk -= dxx;
                    currentSeries.Points.Clear();
                }

            }
            foreach (var p in points)
            {
                var dataPoint = new DataPoint(p.X, p.Y);
                currentSeries.Points.Add(dataPoint);
            }
            currentSeries.Points.Clear();
            ChartPayments.Invalidate();
            answer.Text = Convert.ToString(a);
            return true;
        }
    }
}
