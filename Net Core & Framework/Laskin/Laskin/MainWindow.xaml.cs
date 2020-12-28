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

namespace Laskin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }

            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;


            }
        }
    }
}
