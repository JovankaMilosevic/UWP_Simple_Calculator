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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace JM_A2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Calculator : Page
    {
        string input = "";
        string strNum1 = "";
        string strNum2 = "";
        char operation;
        int result = 0;

        public Calculator()
        {
            this.InitializeComponent();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "7";
            tb_result.Text += input;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "8";
            tb_result.Text += input;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "9";
            tb_result.Text += input;
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            strNum1 = input;
            operation = '/';
            input = "";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "4";
            tb_result.Text += input;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "5";
            tb_result.Text += input;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "6";
            tb_result.Text += input;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            strNum1 = input;
            operation = '+';
            input = "";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "1";
            tb_result.Text += input;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "2";
            tb_result.Text += input;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "3";
            tb_result.Text += input;
        }

        private void ButtonMin_Click(object sender, RoutedEventArgs e)
        {
            strNum1 = input;
            operation = '-';
            input = "";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            input = "";
            strNum1 = "";
            strNum2 = "";
            result = 0;
            tb_result.Text = "";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            tb_result.Text = "";
            input += "0";
            tb_result.Text += input;
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            strNum1 = input;
            operation = '*';
            input = "";
        }

        private void ButtonEq_Click(object sender, RoutedEventArgs e)
        {
            strNum2 = input;
            int num1;
            int num2;

            Int32.TryParse(strNum1, out num1);
            Int32.TryParse(strNum2, out num2);

            switch (operation)
            {
                case '+':
                    {
                        result = num1 + num2;
                        tb_result.Text = result.ToString();
                        break;
                    }
                case '-':
                    {
                        result = num1 - num2;
                        tb_result.Text = result.ToString();
                        break;
                    }
                case '*':
                    {
                        result = num1 * num2;
                        tb_result.Text = result.ToString();
                        break;
                    }
                case '/':
                    {
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            tb_result.Text = result.ToString();
                            break;
                        }
                        else
                        {
                            tb_result.Text = "Cannot divide by 0";
                            break;
                        }

                    }
                default:
                    break;
            }
            input = "";
            operation = '\0';
        }
    }
}
