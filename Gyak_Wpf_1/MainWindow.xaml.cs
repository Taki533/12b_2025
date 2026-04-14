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

namespace Gyak_Wpf_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /* A feladat
     * kérjünk be neveket ezeket a neveket mentsül el fájlba ahogygondolod.txt néven és egy gomnyomásra töltsük be sorba rendezve
     * nekem még egy gomb ahol a listából JSON lesz
     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> nevek = new List<string>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists("ahogygondolod.txt")){
                string[] Letezo =File.ReadAllLines("ahogygondolod.txt");
                nevek = Letezo.ToList();
            }
            nevek.Add(nev.Text);
            StreamWriter w = new StreamWriter("ahogygondolod.txt");
            for (int i = 0; i < nevek.Count; i++)
            {
                w.WriteLine(nevek[i]);
            }
            w.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           string[] nevek = File.ReadAllLines("ahogygondolod.txt");
            Lista.ItemsSource = nevek;
            Lista.Visibility= Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {   
            List<string> Names = File.ReadAllLines("ahogygondolod.txt").ToList();
            StreamWriter w = new StreamWriter("ahogygondolod.json");
            w.WriteLine("{");
            for (int i = 0; i < Names.Count; i++)
            {
                w.WriteLine($"\"name{i}\": \"{Names[i]}\"");
            }
            w.WriteLine("}");    

            w.Close();
        }
    }
}