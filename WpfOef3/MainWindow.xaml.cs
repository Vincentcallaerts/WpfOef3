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

namespace WpfOef3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Geslacht { get; set; }
        public List<string> LeeftijdsGroepen { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Geslacht = new List<string>();

            Geslacht.Add("Man");
            Geslacht.Add("Vrouw");
            Geslacht.Add("Anders");

            LeeftijdsGroepen = new List<string>();

            LeeftijdsGroepen.Add("MinderJarige");
            LeeftijdsGroepen.Add("Volwassen");
            LeeftijdsGroepen.Add("Bejaarde");

            cmbGeslacht.ItemsSource = Geslacht;
            cmbLeeftijd.ItemsSource = LeeftijdsGroepen;
            cmbGeslacht.SelectedIndex = 0;
            cmbLeeftijd.SelectedIndex = 0;

        }

        private void Click_Click(object sender, RoutedEventArgs e)
        {
            string description = $"{cmbLeeftijd.SelectedItem} {cmbGeslacht.SelectedItem}";
            MessageBox.Show(description);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {

            tbFirst.Text = sender.ToString().Substring(sender.ToString().LastIndexOf(':') + 2);
            tbSecond.Text = sender.ToString().Substring(sender.ToString().LastIndexOf(':') + 2);
        }

        private void btnHiddenContent_Click(object sender, RoutedEventArgs e)
        {
            spHidden.Visibility = Visibility.Visible;
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lbGoBlue.Foreground.ToString());

            if (lbGoBlue.Foreground.ToString() == "#FF000000")
            {
                lbGoBlue.Foreground = Brushes.AliceBlue;
            }
        }
    }
}
