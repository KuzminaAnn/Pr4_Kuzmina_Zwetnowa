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
        public static float a;
        public Page4()
        {
            InitializeComponent();
            
            ChartPayments.ChartAreas.Add(new ChartArea("Main"));
            var currentSeries = new Series("График");
            currentSeries.Points.Clear();
//{
//                IsValueShownAsLabel = true
//};

            currentType = SeriesChartType.Line; //new
            ChartPayments.Series.Add(currentSeries);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Series currentSeries = ChartPayments.Series.FirstOrDefault();
            currentSeries.ChartType = SeriesChartType.Line;
            
            float.TryParse(x0.Text, out float xx0);
            float.TryParse(xk.Text, out float xxk);
            float.TryParse(dx.Text, out float dxx);
            float.TryParse(d.Text, out float dd);
            int ass = 0;
            if (xx0 <= xxk)
            {
                while (ass != 5)
                {
                    a = (float)(Pow(xx0, 2) + Tan(5 * xx0 + (dd / xx0)));
                    answer.Text = Convert.ToString(a);
                    points.Add(new Point (xx0, a));
                    xx0 += dxx;
                    ass += 1;
                    currentSeries.Points.Clear();
                }
                ;
            }
            else 
            {
                while (xxk >= xx0)
                {
                    a = (float)(Pow(xxk, 2) + Tan(5 * xxk + (dd / xxk)));
                    answer.Text = Convert.ToString(a);
                    points.Add(new Point(xxk, a));
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
    }
}
