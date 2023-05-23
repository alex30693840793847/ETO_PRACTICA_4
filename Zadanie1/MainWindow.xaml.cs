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

namespace Zadanie1
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
                double a = Convert.ToDouble(A.Text);
                double b = Convert.ToDouble(B.Text);
                switch (vibor)
                {
                    case 1:
                        OTV.Text = $"{a} + {b} = {a + b}";
                        break;
                    case 2:
                        OTV.Text = $"{a} - {b} = {a - b}";
                        break;
                    case 3:
                        OTV.Text = $"{a} * {b} = {a * b}";
                        break;
                    case 4:
                        OTV.Text = $"{a} / {b} = {a / b}";
                        break;
                    default:
                        OTV.Text = $"неверный номер операции";
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
    

