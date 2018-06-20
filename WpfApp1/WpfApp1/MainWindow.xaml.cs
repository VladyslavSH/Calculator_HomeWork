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
        string [] parser = null;
        double num1, num2, rez;
        int flag = 0;
        public MainWindow()
        {
            InitializeComponent();
            foreach (var item in grid.Children)
            {
                if((item as Button) is Button)
                {
                    (item as Button).Click += MainWindow_Click;
                }
            }
        }

        private void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            if((sender as Button).Content.ToString() == "Delete")
            {
                textBlock.Undo();
            }
            else if ((sender as Button).Content.ToString() == "C") textBlock.Clear();
            if ((sender as Button).Content.ToString() == "=")
            {
                parser[0] = textBlock.Text;
                switch((sender as Button).Content.ToString())
                {
                    case "+": ; break;
            } 
            if ((sender as Button).Content.ToString() == "+") { flag = 1; num1 = Convert.ToInt32(textBlock.Text); }
            if ((sender as Button).Content.ToString() == "-") { flag = 2; num1 = Convert.ToInt32(textBlock.Text); }
            if ((sender as Button).Content.ToString() == "*") { flag = 3; num1 = Convert.ToInt32(textBlock.Text); }
            if ((sender as Button).Content.ToString() == "/") { flag = 4; num1 = Convert.ToInt32(textBlock.Text); }
            else textBlock.Text += (sender as Button).Content.ToString();
        }
        

    }
}
