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

namespace BPA_Warm_up____Temp_Conversion
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int F = 0;
            int Celsius = (F - 32) * (5 / 9);
            MessageBox.Show("");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int C = 0;
            int Fahrenheit = C * (9 / 5) + 32;
            MessageBox.Show("");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine();
        }
    }
}