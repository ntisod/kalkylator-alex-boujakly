using System;
using System.Collections.Generic;
using System.Data;
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

namespace räknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

            int sum = 0;
        string newNr = "";
        public MainWindow()

        {
            InitializeComponent();
        }
        private void AddDigit (string nr)
        { 
            textBox1.AppendText(nr);
            newNr += nr;

            }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sum = 0;
            newNr = "";
            textBox1.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.AppendText("/");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }

        private void btn(object sender, RoutedEventArgs e)
        {

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("1");
        }

        private void btn2Click(object sender, RoutedEventArgs e)
        {
            AddDigit("2");

        }

        private void btn3Click(object sender, RoutedEventArgs e)
        {
            AddDigit("3");
        }

        private void btn4Click(object sender, RoutedEventArgs e)
        {
            AddDigit("4");
        }

        private void btn5Click(object sender, RoutedEventArgs e)
        {
            AddDigit("5");
        }

        private void btn6Click(object sender, RoutedEventArgs e)
        {
            AddDigit("6");
        }

        private void btn7Click(object sender, RoutedEventArgs e)
        {
            AddDigit("7");
        }

        private void btn8Click(object sender, RoutedEventArgs e)
        {
            AddDigit("8");
        }

        private void btn9Click(object sender, RoutedEventArgs e)
        {
            AddDigit("9");
        }

        private void btn0Click(object sender, RoutedEventArgs e)
        {
            AddDigit("0");
        }

        private void TextBox1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Bt__Click(object sender, RoutedEventArgs e)
        {
            textBox1.AppendText("+");
        }

        private void Bt_4_Click(object sender, RoutedEventArgs e)
        {
            double result = Convert.ToDouble(new DataTable().Compute(textBox1.Text, null));
            textBox1.Text = result.ToString();
        }

        private void Bt_3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.AppendText("*");
        }

        private void Bt_1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.AppendText("-");
        }
    }
}

