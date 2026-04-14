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

namespace wpf_gyak_3_alkalom
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<int> szamok = new List<int>();
            szamok.Add( int.Parse(szam1.Text));
            szamok.Add( int.Parse(szam2.Text));
            szamok.Add( int.Parse(szam3.Text));
            int legnagyobb = 0;
            foreach (int szam in szamok)
            {
                if(szam > legnagyobb)
                {
                    legnagyobb = szam;
                }
            }
            List<int> kisebbek = new List<int>();
            foreach (int szam in szamok)
            {
                if(szam < legnagyobb)
                {
                     kisebbek.Add(szam);
                }
            }
            eredmeny.Text = "A kettő kissebb szám eredménye: "+Convert.ToString(kisebbek[0] * kisebbek[1]);

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            honnan.Maximum = szoveg.Text.Length;
            hova.Maximum = szoveg.Text.Length;
            eredmeny2.Text = szoveg.Text.Substring(Convert.ToInt32(honnan.Value),Convert.ToInt32(hova.Value));
        }

        private void honnan_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            honnan.Maximum = szoveg.Text.Length;
            hova.Maximum = szoveg.Text.Length;
            eredmeny2.Text = szoveg.Text.Substring(Convert.ToInt32(honnan.Value), Convert.ToInt32(hova.Value));
        }

        private void hova_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            honnan.Maximum = szoveg.Text.Length;
            hova.Maximum = szoveg.Text.Length;
            hova.Minimum = honnan.Value+1;
            eredmeny2.Text = szoveg.Text.Substring(Convert.ToInt32(honnan.Value), Convert.ToInt32(hova.Value));
        }
    }
}