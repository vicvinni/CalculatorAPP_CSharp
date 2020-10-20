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

namespace WpfStaticCalculator
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
        float num1, ans;
        int count;

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 9;
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 8;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 7;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 6;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 5;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 4;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 3;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 2;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 1;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text + 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            txtResult.Focus();
            count = 2;
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            txtResult.Focus();
            count = 3;
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text != "") { 
                num1 = float.Parse(txtResult.Text);
                txtResult.Clear();
                txtResult.Focus();
                count = 1;
            }
        }

        
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(txtResult.Text);
            txtResult.Clear();
            txtResult.Focus();
            count = 4;
        }
        
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtResult.Text);
                    txtResult.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

    }
}
