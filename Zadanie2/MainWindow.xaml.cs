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

namespace Zadanie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string rank, suit;
            try
            {
                double n = Convert.ToDouble(N.Text);
                double m = Convert.ToDouble(M.Text);
                switch (n)
                {
                    case 6:
                        rank = "шестерка";
                        break;
                    case 7:
                        rank = "семерка";
                        break;
                    case 8:
                        rank = "восьмерка";
                        break;
                    case 9:
                        rank = "девятка";
                        break;
                    case 10:
                        rank = "десятка";
                        break;
                    case 11:
                        rank = "валет";
                        break;
                    case 12:
                        rank = "дама";
                        break;
                    case 13:
                        rank = "король";
                        break;
                    case 14:
                        rank = "туз";
                        break;
                    default:
                        rank = "ошибка";
                        break;
                }
                switch (m)
                {
                    case 1:
                        suit = "пики";
                        break;
                    case 2:
                        suit = "трефы";
                        break;
                    case 3:
                        suit = "бубны";
                        break;
                    case 4:
                        suit = "червы";
                        break;
                    default:
                        suit = "ошибка";
                        break;
                }
                OTV.Text = $"{rank} {suit}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
