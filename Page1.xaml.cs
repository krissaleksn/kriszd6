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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(kra.Text);
            string kr = "";
            switch (a)
            {
                case 1: kr = "плохо"; break;
                case 2: kr = "неудовлетворительно"; break;
                case 3: kr = "удовлетворительно"; break;
                case 4: kr = "хорошо"; break;
                case 5: kr = "отлично"; break;
                default:
                    kr = "ошибка";
                    break;
            }
            zad.Text = $"Ответ: {kr}";
        }
    }
}
