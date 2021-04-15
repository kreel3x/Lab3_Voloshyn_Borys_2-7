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

namespace zadanie_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement c in LayoutRoot.Children)
            {
                if (c is Button)
                {
                    ((Button)c).Click += Btn_Click;
                }
            }
        }
        string leftOperand = "0";
        string operation = "";
        string rightOperand = "";
        int operationCounter;
        bool resStatus = false;
        bool delSum = false;
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            textBlock.Text += s;
            int num;
            bool result = Int32.TryParse(s, out num);

            if (result == true)
            {
                if (operation == "" && leftOperand == "0")
                {
                    textBlock.Text = s;
                    leftOperand = s;
                    AllClearBtn.Content = "C";
                }
                else if (operation == "")
                {
                    leftOperand += s;
                    AllClearBtn.Content = "C";
                }
                else
                {
                    rightOperand += s;
                    AllClearBtn.Content = "C";
                    operationCounter = 0;
                }
            }
            else
            {
                if (s == "=")
                {
                    if (leftOperand != "" && rightOperand != "")
                    {
                        delSum = true;
                        Upd_LeftOperation();
                        if (resStatus == true)
                        {
                            textBlock.Text = textBlock.Text.Remove(textBlock.Text.Length - leftOperand.Length - 1);
                        }
                        textBlock.Text += leftOperand;
                        operation = "";
                        operationCounter = 0;
                        resStatus = true;
                    }
                    else
                    {
                        leftOperand = "0";
                        rightOperand = "";
                        operation = "";
                        textBlock.Text = "0";
                        operationCounter = 0;
                        delSum = false;
                    }

                }
                else if (s == "AC")
                {
                    leftOperand = "0";
                    rightOperand = "";
                    operation = "";
                    textBlock.Text = "0";
                    AllClearBtn.Content = "AC";
                    operationCounter = 0;
                    delSum = false;
                }
                else if (s == "C")
                {
                    leftOperand = "0";
                    rightOperand = "";
                    operation = "";
                    textBlock.Text = "0";
                    AllClearBtn.Content = "AC";
                    operationCounter = 0;
                    delSum = false;
                }
                else
                {
                    if (delSum == true)
                    {
                        textBlock.Text = textBlock.Text.Substring(textBlock.Text.Length - leftOperand.Length - 1);
                        delSum = false;
                    }
                    resStatus = false;
                    AllClearBtn.Content = "C";
                    operationCounter++;
                    if (operationCounter > 1)
                    {
                        textBlock.Text = textBlock.Text.Substring(0, textBlock.Text.Length - 2) + textBlock.Text.Substring(textBlock.Text.Length - 1);
                        operationCounter = 1;
                    }
                    if (rightOperand != "")
                    {
                        Upd_LeftOperation();
                        rightOperand = "";
                    }
                    operation = s;


                }
            }
        }
        private void Upd_LeftOperation()
        {
            double num1 = double.Parse(leftOperand);
            double num2 = double.Parse(rightOperand);
            switch (operation)
            {
                case "+":
                    leftOperand = (num1 + num2).ToString();
                    break;
                case "-":
                    leftOperand = (num1 - num2).ToString();
                    break;
                case "*":
                    leftOperand = (num1 * num2).ToString();
                    break;
                case "/":
                    leftOperand = (num1 / num2).ToString();
                    break;
            }
        }


    }
}







