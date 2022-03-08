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
using System.Text.RegularExpressions;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static string expression;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Moner_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "7";
            expression += "7";
        }

        private void Violet_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "8";
            expression += "8";
        }

        private void Lilia_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "9";
            expression += "9";
        }

        private void Roza_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "+";
            expression += "+";
        }

        private void Romashka_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "4";
            expression += "4";
        }

        private void Orhidea_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "5";
            expression += "5";
        }

        private void Landash_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "6";
            expression += "6";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "-";
            expression += "-";
        }

        private void Trava_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "1";
            expression += "1";
        }

        private void Derevo_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "2";
            expression += "2";
        }

        private void Skuns_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "3";
            expression += "3";
        }

        private void Star_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "*";
            expression += "*";
        }

        private void Bereza_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "0";
            expression += "0";
        }

        private void Karta_Click(object sender, RoutedEventArgs e)
        {
            inputTextBlock.Text += "/";
            expression += "/";
        }

        private void Dub_Click(object sender, RoutedEventArgs e)
        {
            Regex r = new Regex(@"[-+*/]+");
            Match tel = r.Match(inputTextBlock.Text);
            string znak = "0";
            while (tel.Success)
            {
                znak = Convert.ToString(tel);
                tel = tel.NextMatch();
            }
            string text = inputTextBlock.Text;
            string[] newText = Regex.Split(text, "[-+/*]+");
            if (znak == "+")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) + Convert.ToDouble(newText[1]))}";
            else if (znak == "-")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) - Convert.ToDouble(newText[1]))}";
            else if (znak == "*")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) * Convert.ToDouble(newText[1]))}";
            else if (znak == "/")
                inputTextBlock.Text = $"{Convert.ToString(Convert.ToDouble(newText[0]) / Convert.ToDouble(newText[1]))}";
            else
                inputTextBlock.Text = "Ошибка";
        }
    }
}
