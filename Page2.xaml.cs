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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int r = int.Parse(jo.Text);
            string q = "";
            switch (r / 10)
            {
                case 2: q += "двадцать "; break;
                case 3: q += "тридцать "; break;
                case 4: q += "сорок "; break;
                case 5: q += "пятьдесят "; break;
                case 6: q += "шестьдесят "; break;
                default:
                    break;
            }
            switch (r % 10)
            {
                case 1: q += "один "; break;
                case 2: q += "два "; break;
                case 3: q += "три "; break;
                case 4: q += "четыре "; break;
                case 5: q += "пять "; break;
                case 6: q += "шесть "; break;
                case 7: q += "семь "; break;
                case 8: q += "восемь "; break;
                case 9: q += "девять "; break;
                default:
                    break;
            }
            switch (r % 10)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: q += "лет "; break;
                case 1: q += "год"; break;
                case 2:
                case 3:
                case 4: q += "года"; break;
                default:
                    break;
            }
            zad.Text = $"Ответ: {q}";
        }
    }
}
