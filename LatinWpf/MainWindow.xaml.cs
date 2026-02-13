using System.IO;
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

namespace LatinWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // A lista, ami az összes adatot tárolja
        List<Adatok> adatok = new List<Adatok>();

        public MainWindow()
        {
            InitializeComponent();
            AdatokBetoltese();
        }

        private void AdatokBetoltese()
        {
            try
            {
                // Fájl beolvasása (Figyelj rá, hogy a tancrend.txt a bin/Debug mappában legyen!)
                // Ha nincs fájlod, hozz létre egyet teszteléshez vagy cseréld le a path-t.
                if (File.Exists("tancrend.txt"))
                {
                    var rawData = File.ReadAllLines("tancrend.txt").Chunk(3).ToArray();

                    foreach (var chunk in rawData)
                    {
                        // 0: tánc, 1: lány, 2: fiú
                        adatok.Add(new Adatok(chunk[0], chunk[1], chunk[2]));
                    }

                    txtStatus.Text = "Adatok sikeresen betöltve.";
                    StatikusFeladatokMegoldasa();
                    LegordulokFeltoltese();
                }
                else
                {
                    txtStatus.Text = "HIBA: A tancrend.txt nem található!";
                    MessageBox.Show("Kérlek másold a tancrend.txt fájlt a program mappájába!");
                }
            }
            catch (Exception ex)
            {
                txtStatus.Text = "Hiba történt: " + ex.Message;
            }
        }

        private void StatikusFeladatokMegoldasa()
        {
            if (adatok.Count == 0) return;

            // 2. Feladat
            lblElsoUtolso.Text = $"Első tánc: {adatok.First().TancNeve}, Utolsó tánc: {adatok.Last().TancNeve}";

            // 3. Feladat
            int sambaCount = adatok.Count(x => x.TancNeve == "samba");
            lblSambaCount.Text = $"{sambaCount} alkalommal adták elő.";

            // 6. Feladat (Fiúk listázása)
            var fiuk = adatok.Select(x => x.FiuNeve).Distinct().OrderBy(x => x);
            lblFiukListaja.Text = string.Join(", ", fiuk);
        }

        private void LegordulokFeltoltese()
        {
            // Egyedi lányok kigyűjtése és betöltése a ComboBoxba
            var lanyok = adatok.Select(x => x.LanyNeve).Distinct().OrderBy(x => x).ToList();
            cbLanyok.ItemsSource = lanyok;

            // Egyedi táncok kigyűjtése
            var tancok = adatok.Select(x => x.TancNeve).Distinct().OrderBy(x => x).ToList();
            cbTancok.ItemsSource = tancok;
        }

        // Ez a függvény fut le, ha BÁRMELYIK legördülő menüt módosítod
        private void UpdateEredmenyek(object sender, SelectionChangedEventArgs e)
        {
            if (adatok.Count == 0) return;

            string kivalasztottLany = cbLanyok.SelectedItem as string;
            string kivalasztottTanc = cbTancok.SelectedItem as string;

            // 4. Feladat: Ha van kiválasztva lány, listázzuk a táncait
            if (!string.IsNullOrEmpty(kivalasztottLany))
            {
                var lanyTancai = adatok
                    .Where(x => x.LanyNeve == kivalasztottLany)
                    .Select(x => x.TancNeve)
                    .ToList();

                lblLanyTancai.Text = string.Join(", ", lanyTancai);
            }

            // 5. Feladat: Ha VAN kiválasztva lány ÉS tánc is, keressük a párt
            if (!string.IsNullOrEmpty(kivalasztottLany) && !string.IsNullOrEmpty(kivalasztottTanc))
            {
                var par = adatok.FirstOrDefault(x => x.LanyNeve == kivalasztottLany && x.TancNeve == kivalasztottTanc);

                if (par != null)
                {
                    lblKeresettPar.Text = $"{kivalasztottTanc} bemutatóján {kivalasztottLany} párja: {par.FiuNeve}";
                    lblKeresettPar.Foreground = System.Windows.Media.Brushes.Green;
                }
                else
                {
                    lblKeresettPar.Text = $"{kivalasztottLany} nem táncolt {kivalasztottTanc}-t.";
                    lblKeresettPar.Foreground = System.Windows.Media.Brushes.Red;
                }
            }
            else
            {
                lblKeresettPar.Text = "Kérlek válassz lányt és táncot is a kereséshez!";
                lblKeresettPar.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }
    }
}