using Microsoft.Windows.Themes;
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

namespace Bekeres
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
        int marginTop = 50;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 1. Szöveg kinyerése és ürítés
            string bevittSzoveg = szöveg.Text;
            szöveg.Text = "";

            // 2. Elemek létrehozása
            Label label = new Label { Content = bevittSzoveg };

            Border border = new Border
            {
                BorderThickness = new Thickness(2),
                BorderBrush = Brushes.Black, // Keret színe (enélkül láthatatlan maradhat)
                Child = label,
                Margin = new Thickness(100,marginTop,150,200), // Hogy ne érjenek össze
                HorizontalAlignment = HorizontalAlignment.Right,// Így felülre igazodik
                Height = 50,
                Width = 50
            };
            marginTop += marginTop;
            // 3. Hozzáadás a tárolóhoz
            // Ha a XAML-ben <Grid x:Name="MainGrid"> van:
            Grid.Children.Add(border);
        }
    }
}