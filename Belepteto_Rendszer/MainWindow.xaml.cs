using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Text.RegularExpressions;

namespace Belepteto_Rendszer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            betoltes();
        }
        List<Adat> adatok = new List<Adat>();
        void betoltes()
        {
            string[] sorok = File.ReadAllLines("bedat.txt");
            
            foreach (string sor in sorok)
            {
                adatok.Add(new Adat(sor));
            }
        }

        private void elso_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Name == "elso")
            {
                dolgok.Text = adatok.First().ido;
            }
            else {
                dolgok.Text = adatok.Last().ido;
            }


        }

        private void utso_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void keres_Click(object sender, RoutedEventArgs e)
        {
            string innen = _in.Text;
            string eddig = oda.Text;
            Regex idominta = new Regex(@"^([01]\d|2\d):([0-5]\d)$");
            if (idominta.IsMatch(innen))
            {
                _in.Foreground = Brushes.Black;
            }
            else {
                _in.Foreground = Brushes.Red;
                _in.Focus();
            }
            if (idominta.IsMatch(eddig))
            {
                oda.Foreground = Brushes.Black;
            }
            else {
                oda.Foreground = Brushes.Red;
                oda.Focus();
            }

        }
    }
}