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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            botonAzul.IsChecked = true;
            // botonRojo.IsIsChecked = true;
        }

        private void negrita_Checked(object sender, RoutedEventArgs e)
        {
            texto.FontWeight = FontWeights.Bold;
        }

        private void cursiva_Checked(object sender, RoutedEventArgs e)
        {
            texto.FontStyle = FontStyles.Italic;
        }

        private void botonAzul_Checked(object sender, RoutedEventArgs e)
        {
            texto.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void botonRojo_Checked(object sender, RoutedEventArgs e)
        {
            texto.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void botonVerde_Checked(object sender, RoutedEventArgs e)
        {
            texto.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void cuadroTexto_TextChanged(object sender, TextChangedEventArgs e)
        {
            texto.Content = cuadroTexto.Text;
        }
    }
}
