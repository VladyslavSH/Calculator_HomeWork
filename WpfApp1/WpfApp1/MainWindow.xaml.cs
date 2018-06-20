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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1, num2, rez;
        int flag = 0;
        public MainWindow()
        {
            InitializeComponent();
            foreach (var item in grid.Children)
            {
                if ((item as Button) is Button)
                {
                    (item as Button).Click += MainWindow_Click;
                }
            }
        }

        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content.ToString() == "Delete")
            {
                textBlock.Undo();
            }
            else if ((sender as Button).Content.ToString() == "C") { textBlock.Clear(); num1 = 0; num2 = 0; textBox.Clear(); }
            else if ((sender as Button).Content.ToString() == "=")
            {
                num2 = Convert.ToDouble(textBlock.Text);
                switch (flag)
                {
                    case 1: rez = num1 + num2; break;
                    case 2: rez = num1 - num2; break;
                    case 3: rez = num1 * num2; break;
                    case 4: rez = num1 / num2; break;
                }
                textBox.Text += textBlock.Text + " = " + rez;
                textBlock.Clear();
                num1 = 0; num2 = 0;
            }
            else if ((sender as Button).Content.ToString() == "+") { flag = 1; num1 = Convert.ToDouble(textBlock.Text); textBox.Text = textBlock.Text + "+"; textBlock.Clear(); }
            else if ((sender as Button).Content.ToString() == "-") { flag = 2; num1 = Convert.ToDouble(textBlock.Text); textBox.Text = textBlock.Text + "-"; textBlock.Clear(); }
            else if ((sender as Button).Content.ToString() == "*") { flag = 3; num1 = Convert.ToDouble(textBlock.Text); textBox.Text = textBlock.Text + "*"; textBlock.Clear(); }
            else if ((sender as Button).Content.ToString() == "/") { flag = 4; num1 = Convert.ToDouble(textBlock.Text); textBox.Text = textBlock.Text + "/"; textBlock.Clear(); }

            else textBlock.Text += (sender as Button).Content.ToString();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(rez);
            Console.WriteLine();
        }
    }
}
