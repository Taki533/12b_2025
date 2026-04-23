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
namespace NyelvVizsga
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<vizsga> vizsgakSikeres = new List<vizsga>();
        public MainWindow()
        {
            InitializeComponent();
                

        }
        void betolt()
        {
            string[] sorokSikeres = File.ReadAllLines("sikeres.csv").Skip(1).ToArray();

            foreach (var sor in sorokSikeres)
            {
                vizsgakSikeres.Add(new vizsga(sor));
            }
        }
    }
}