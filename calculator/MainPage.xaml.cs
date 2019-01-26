using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace calculator
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string currentNum1;
        private string currentNum2;
        private bool noOperation = true;
        private char op;
        private double result = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "1";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "1";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "7";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "7";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_8_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "8";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "8";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_9_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "9";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "9";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_divide_Click(object sender, RoutedEventArgs e) {
            noOperation = false;
            op = '/';
            inputTB.Text += op.ToString();
        }

        private void Button_4_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "4";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "4";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_5_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "5";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "5";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_6_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "6";
                inputTB.Text += currentNum1;
            }
            else {
                currentNum2 += "6";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_multi_Click(object sender, RoutedEventArgs e) {
            noOperation = false;
            op = '*';
            inputTB.Text += op.ToString();
        }

        private void Button_2_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "2";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "2";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "3";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "3";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_subtract_Click(object sender, RoutedEventArgs e) {
            noOperation = false;
            op = '-';
            inputTB.Text += op.ToString();
        }

        private void Button_zero_Click(object sender, RoutedEventArgs e) {
            if (noOperation) {
                currentNum1 += "0";
                inputTB.Text = currentNum1;
            }
            else {
                currentNum2 += "0";
                inputTB.Text += currentNum2;
            }
        }

        private void Button_point_Click(object sender, RoutedEventArgs e) {

        }

        private void Button_equal_Click(object sender, RoutedEventArgs e) {
            switch (op) {
                case '+':result = double.Parse(currentNum1) + double.Parse(currentNum2); break;
                case '-':result = double.Parse(currentNum1) - double.Parse(currentNum2); break;
                case '*':result = double.Parse(currentNum1) * double.Parse(currentNum2); break;
                case '/':result = double.Parse(currentNum1) / double.Parse(currentNum2); break;
                default:
                    break;
            }

            resultTB.Text = result.ToString();
        }

        private void Button_add_Click(object sender, RoutedEventArgs e) {
            noOperation = false;
            op = '+';
            inputTB.Text += op.ToString();
        }

        private void Button_refresh_Click(object sender, RoutedEventArgs e) {
            resultTB.Text = "";
            inputTB.Text = "";
            currentNum1 = "";
            currentNum2 = "";
            result = 0;
            noOperation = true;
        }
    }
}
