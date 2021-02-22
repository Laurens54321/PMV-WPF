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

namespace View
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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            String inputString = textBox.Text;
            if (inputString.Length == 0) return;
            try
            {
                int F = int.Parse(inputString);
                int C = (F - 32) * 5 / 9;
                String output = C.ToString();
                textBox.Text = output + "C°";
            }
            catch (FormatException error)
            {
                textBox.Text = "Input could not be parsed";
            }
        }
    }
}
