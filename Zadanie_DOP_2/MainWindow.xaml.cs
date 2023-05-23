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

namespace Zadanie_DOP_2
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
                if(ch >= 100 && ch <= 999)
                {
                    switch (ch / 100)
                    {
                        case 1:
                            result += "сто ";
                            break;
                        case 2:
                            result += "двести ";
                            break;
                        case 3:
                            result += "триста ";
                            break;
                        case 4:
                            result += "четыреста ";
                            break;
                        case 5:
                            result += "пятьсот ";
                            break;
                        case 6:
                            result += "шестьсот ";
                            break;
                        case 7:
                            result += "семьсот ";
                            break;
                        case 8:
                            result += "восемьсот ";
                            break;
                        case 9:
                            result += "девятьсот ";
                            break;
                    }

                    if ((ch % 100 / 10) == 1)
                    {
                        switch (ch % 100)
                        {
                            case 10:
                                result += "десять";
                                break;
                            case 11:
                                result += "одинадцать";
                                break;
                            case 12:
                                result += "двенадцать";
                                break;
                            case 13:
                                result += "тринадцать";
                                break;
                            case 14:
                                result += "четырнадцать";
                                break;
                            case 15:
                                result += "пятнадцать";
                                break;
                            case 16:
                                result += "шестнадцать";
                                break;
                            case 17:
                                result += "семнадцать";
                                break;
                            case 18:
                                result += "восемнадцать";
                                break;
                            case 19:
                                result += "девятнадцать";
                                break;
                        }
                    }
                    else
                    {
                        switch (ch % 100 / 10)
                        {
                            case 2:
                                result += "двадцать ";
                                break;
                            case 3:
                                result += "тридцать ";
                                break;
                            case 4:
                                result += "сорок ";
                                break;
                            case 5:
                                result += "пятьдесят ";
                                break;
                            case 6:
                                result += "шестьдесят ";
                                break;
                            case 7:
                                result += "семьдесят ";
                                break;
                            case 8:
                                result += "восемьдесят ";
                                break;
                            case 9:
                                result += "девяносто ";
                                break;
                        }

                        switch (ch % 10)
                        {
                            case 1:
                                result += "один";
                                break;
                            case 2:
                                result += "два";
                                break;
                            case 3:
                                result += "три";
                                break;
                            case 4:
                                result += "четыре";
                                break;
                            case 5:
                                result += "пять";
                                break;
                            case 6:
                                result += "шесть";
                                break;
                            case 7:
                                result += "семь";
                                break;
                            case 8:
                                result += "восемь";
                                break;
                            case 9:
                                result += "девять";
                                break;
                        }
                    }
                    OTV.Text = $"{result}";
                }
                else
                {
                    OTV.Text = $"число не входит в диапозон";
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
