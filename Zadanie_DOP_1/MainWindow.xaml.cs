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

namespace Zadanie_DOP_1
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
                int ch = Convert.ToInt32(CHICLO.Text);
                string result = "";
                if (ch >= 10 && ch <= 40) 
                {
                    if (ch >= 10 && ch < 20) 
                    {
                        switch (ch)
                        {
                            case 10:
                                result = "десять учебных заданий";
                                break;
                            case 11:
                                result = "одиннадцать учебных заданий";
                                break;
                            case 12:
                                result = "двенадцать учебных заданий";
                                break;
                            case 13:
                                result = "тринадцать учебных заданий";
                                break;
                            case 14:
                                result = "четырнадцать учебных заданий";
                                break;
                            case 15:
                                result = "пятнадцать учебных заданий";
                                break;
                            case 16:
                                result = "шестнадцать учебных заданий";
                                break;
                            case 17:
                                result = "семнадцать учебных заданий";
                                break;
                            case 18:
                                result = "восемнадцать учебных заданий";
                                break;
                            case 19:
                                result = "девятнадцать учебных заданий";
                                break;
                        }
                    }
                    else 
                    {
                        int first = ch / 10; 
                        int second = ch % 10; 

                        switch (first)
                        {
                            case 2:
                                result = "двадцать ";
                                break;
                            case 3:
                                result = "тридцать ";
                                break;
                            case 4:
                                result = "сорок ";
                                break;
                        }

                        switch (second)
                        {
                            case 1:
                                result += "одно учебное задание";
                                break;
                            case 2:
                                result += "два учебных задания";
                                break;
                            case 3:
                                result += "три учебных задания";
                                break;
                            case 4:
                                result += "четыре учебных задания";
                                break;
                            case 5:
                                result += "пять учебных заданий";
                                break;
                            case 6:
                                result += "шесть учебных заданий";
                                break;
                            case 7:
                                result += "семь учебных заданий";
                                break;
                            case 8:
                                result += "восемь учебных заданий";
                                break;
                            case 9:
                                result += "девять учебных заданий";
                                break;
                            default:
                                result += "учебных заданий";
                                break;
                        }
                    }
                    OTV.Text = $"{result}";
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
