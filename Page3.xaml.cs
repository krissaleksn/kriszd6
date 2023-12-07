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
            int n = int.Parse(numn.Text);
            double x = double.Parse(numm.Text);
            double a = 0, h = 0, c = 0, s = 0;
            switch (n)
            {
                case 1:
                    a = x;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    break;
                case 2:
                    c = x;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    break;
                case 3:
                    h = x;
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    s = c * h / 2;
                    break;
                case 4:
                    s = x;
                    h = Math.Sqrt(s);
                    c = 2 * h;
                    a = c / Math.Sqrt(2);
                    break;
                default:
                    break;
            }
            zad.Text = $"Ответ: a = {a}\n c = {c}\n h = {h}\n s = {s}";
        }
    }
}
