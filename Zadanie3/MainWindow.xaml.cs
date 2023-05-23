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

namespace Zadanie3
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
            try
            {
                int vibor = Convert.ToInt32(DEISTVIE.Text);
                int znachenie = Convert.ToInt32(ZNACHENIE.Text);
                double a, c, h, S;
                switch (vibor)
                {
                    case 1:
                        a = znachenie;
                        c = a * Sqrt(2);
                        h = c / 2;
                        S = c * h / 2;
                        OTV.Text = $"Площадь: {S}" + $"\nВысота: {h}" + $"Г\nГипотенуза: {c}";
                        break;
                    case 2:
                        c = znachenie;
                        a = c / Sqrt(2);
                        h = c / 2;
                        S = c * h / 2;
                        OTV.Text = $"Площадь: {S}" + $"\nКатет: {a}" + $"\nВысота: {h}";
                        break;
                    case 3:
                        h = znachenie;
                        c = h * 2;
                        a = c / Sqrt(2);
                        S = c * h / 2;
                        OTV.Text = $"Площадь: {S}" + $"\nКатет: {a}" + $"\nГипотенуза: {c}";
                        break;
                    case 4:
                        S = znachenie;
                        c = Sqrt(S * 8);
                        h = c / 2;
                        a = c / Sqrt(2);
                        OTV.Text = $"Высота: {h}" + $"\nКатет: {a}" + $"\nГипотенуза: {c}";
                        break;
                    default:
                        OTV.Text = $"Неверный номер элемента";
                        break;
                }
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
