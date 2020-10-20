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
using CalculatorApp; 

namespace CalculatorGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
       double num1;
       double num2;
       double total;

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToInt32(numtxt1.Text);
            num2 = Convert.ToInt32(numtxt2.Text);

            total = Calculator.Add(num1, num2);
            result.Text = total.ToString();
        }

        private void subbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToInt32(numtxt1.Text);
            num2 = Convert.ToInt32(numtxt2.Text);

            total = Calculator.Subtract(num1, num2);
            result.Text = total.ToString();
        }

        private void divbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToInt32(numtxt1.Text);
            num2 = Convert.ToInt32(numtxt2.Text);

            total = Calculator.Divide(num1, num2);
            result.Text = total.ToString();

        }

        private void multbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToInt32(numtxt1.Text);
            num2 = Convert.ToInt32(numtxt2.Text);

            total = Calculator.Multiply(num1, num2);
            result.Text = total.ToString();
        }
       

        private void modbtn_Click(object sender, RoutedEventArgs e)
        {
            num1 = Convert.ToInt32(numtxt1.Text);
            num2 = Convert.ToInt32(numtxt2.Text);
            total = Calculator.Modulus(num1, num2);
            result.Text = total.ToString();
        }
    }
}
