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
        private List<Persoon> Persoons { get; set; }
        private List<CheckBox> CheckBoxes { get; set; }

        public string TextBoxTextCopied { get; set; }
        public string TextBoxTextCurrentValue { get; set; }
        public string TextBoxTextOldValue { get; set; }




        public MainWindow()
        {
            InitializeComponent();

            CheckBoxes = new List<CheckBox>();

            CheckBoxes.Add(cbRood);
            CheckBoxes.Add(cbGroen);
            CheckBoxes.Add(cbGeel);
            CheckBoxes.Add(cbBlauw);
            CheckBoxes.Add(cbOrange);

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

            Persoons = new List<Persoon>();

            Persoons.Add(new Persoon("Ken", "Field", false));
            Persoons.Add(new Persoon("Ben", "Field", true));
            Persoons.Add(new Persoon("Gwen", "Field", false));
            Persoons.Add(new Persoon("Ben", "Field", true));
            Persoons.Add(new Persoon("Gwen", "Field", false));
            Persoons.Add(new Persoon("Ben", "Field", true));
            Persoons.Add(new Persoon("Gwen", "Field", false));

            lbPerson.ItemsSource = Persoons;
            
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

            if (lbGoBlue.Foreground.ToString() == "#FF000000")
            {
                lbGoBlue.Foreground = Brushes.AliceBlue;
                btnBlue.Content = "Come Back";
            }
            else
            {
                lbGoBlue.Foreground = Brushes.Black;
                btnBlue.Content = "Be Gone";

            }
        }

        private void miClear_Click(object sender, RoutedEventArgs e)
        {

            tbMenuManipulation.Text = String.Empty;

        }

        private void miCopy_ClickCopie(object sender, RoutedEventArgs e)
        {
            TextBoxTextCopied = tbMenuManipulation.Text;
        }

        private void miPaste_ClickPaste(object sender, RoutedEventArgs e)
        {
            tbMenuManipulation.Text += TextBoxTextCopied;
        }
        private void miPaste_ClickRedo(object sender, RoutedEventArgs e)
        {
            tbMenuManipulation.Text = TextBoxTextOldValue;

        }
        private void miPaste_ClickUndo(object sender, RoutedEventArgs e)
        {
            tbMenuManipulation.Text = TextBoxTextOldValue;
        }

        private void tbMenuManipulation_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox text = sender as TextBox;

            TextBoxTextOldValue = TextBoxTextCurrentValue;
            TextBoxTextCurrentValue = tbMenuManipulation.Text;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox check = sender as CheckBox;
            
            switch (check.Content.ToString())
            {
                case "Rood":
                    cbRood.Foreground = Brushes.Red;
                    break;
                case "Groen":
                    cbGroen.Foreground = Brushes.Green;

                    break;
                case "Geel":
                    cbGeel.Foreground = Brushes.Yellow;

                    break;
                case "Blauw":
                    cbBlauw.Foreground = Brushes.Blue;

                    break;
                case "Orange":
                    cbOrange.Foreground = Brushes.Orange;

                    break;
            }
        }

        private void btnCheckers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Checkbox Rood : {CheckBoxes[0].IsChecked}\nCheckbox Groen : {CheckBoxes[1].IsChecked}\nCheckbox Geel : {CheckBoxes[2].IsChecked}\nCheckbox Blauw : {CheckBoxes[3].IsChecked}\nCheckbox Orange : {CheckBoxes[4].IsChecked}\n");
        }
    }
}
