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
using System.Windows.Threading;

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
        enum kodok
        {
            
            Belepes=1,
            Kilepes =2,
            Menza=3,
            Konyvtar=4

        }
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

        List<string> kesok = new List<string>();
        private void keres_Click(object sender, RoutedEventArgs e)
        {
            bool isGood = true;
            string innen = _in.Text;
            string eddig = oda.Text;
            Regex idominta = new Regex(@"^([01]?\d|2[0-3]):([0-5]\d)$");
            if (idominta.IsMatch(innen))
            {
                _in.Foreground = Brushes.Black;
            }
            else {
                _in.Foreground = Brushes.Red;
                _in.Focus();
                isGood = false;
            }
            if (idominta.IsMatch(eddig))
            {
                oda.Foreground = Brushes.Black;
            }
            else {
                oda.Foreground = Brushes.Red;
                oda.Focus();
                isGood = false;
            }
            kesok = adatok.Where(x => x >= innen && x <= eddig).Select(x => x.ido + " " + x.kod).ToList();
            if (kesok.Any())
            {
                lista.ItemsSource = kesok;
            }
        }
        private void fajl_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllLines("kesok.txt", kesok);
            MessageBox.Show("A kesok.txt Fájl Létrehozva.");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox elem = (ComboBox)sender;
            var result = adatok.Where(x => x.esemenyKod == (elem.SelectedIndex+1));
            valasztott.Text = result.Count().ToString()+" darab";
            
        }

        private void bal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox elem = (ComboBox)sender;
            int kivalasztva = elem.SelectedIndex+1;
            var results = adatok.Where(x => x.esemenyKod == kivalasztva).Select(x => x.kod).Distinct().ToList();

            if (elem.Name == "bal")
            {
                balLabel.Content = results.Count().ToString();
            }
            else
            {
                jobbLabel.Content = results.Count().ToString();
            }
            if (balLabel.Content != "" && jobbLabel.Content!="")
            {
                if(Convert.ToInt32(balLabel.Content)> Convert.ToInt32(jobbLabel.Content)){
                    Relacio.Content = ">";
                }
                else if (Convert.ToInt32(balLabel.Content) < Convert.ToInt32(jobbLabel.Content))
                {
                    Relacio.Content = "<";
                }
                else
                {
                    Relacio.Content= "=";
                }
            }
        }

        private void id10t_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mávos bazsi megjelent");
        }
        DispatcherTimer timer;
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += suliBelepes;
            timer.Start();

        }
        int aktualisido = 7 * 60 + 0;
        int lepes = 10; //perc
        void suliBelepes(object sender ,EventArgs e)
        {
            var bement = adatok.Where(a => a <= aktualisido).ToList();
            bent.ItemsSource = bement;
            szamlalo.Content = bement.Count().ToString();

            ora.Content = (aktualisido/60).ToString()+":"+(aktualisido%60).ToString();
            aktualisido += lepes;
            if (aktualisido > 19 * 60)
            {
                aktualisido = 7 * 60;
            }
        }
    }
}