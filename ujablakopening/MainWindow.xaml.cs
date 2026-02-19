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

namespace ujablakopening;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    int kattint =0;
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Window1 ablak = new Window1(kattint);
        ablak.Show();
        ablak.WindowStartupLocation = WindowStartupLocation.Manual;
        ablak.Left = 600;
        ablak.Top = 500;
        kattint++;
    }
}