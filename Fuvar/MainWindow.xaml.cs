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

namespace Fuvar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<EgyFuvar> fuvarok = new List<EgyFuvar>();
        public MainWindow()
        {
            InitializeComponent();
            betolt();
        }

        public void betolt()
        {
            string[] sorok = File.ReadAllLines("fuvar.csv").Skip(1).ToArray();
            foreach (string sor in sorok)
            {
                fuvarok.Add(new EgyFuvar(sor));
            }

            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            feladat3.Text = fuvarok.Count.ToString();
        }
    }
}