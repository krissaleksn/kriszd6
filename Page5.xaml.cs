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

namespace kristinazd5
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double p = double.Parse(nump.Text);
            int k = 0;
            double s = 0;
            double day = 10;
            while (s < 200)
            {
                s += day;
                day += day * p / 100;
                k++;
            }
            zad.Text = $"Ответ: общее расстояние {s:f2}, за сколько дней {k} ";
        }
    }
}
