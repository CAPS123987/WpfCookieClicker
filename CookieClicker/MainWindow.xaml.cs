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

namespace CookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Game game = new Game();
        UpgradeWindow upgradeWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCookieClickEvent(object sender, RoutedEventArgs e)
        {
            game.handleClick();
            updateStats();
        }

        public void updateStats()
        {
            lblCookieCount.Content = "Počet sušenek: " + game.Cookies;
            lblTotalClickCount.Content = "Počet kliknutí: " + game.TotalClicks;
            lblCookieTotalCount.Content = "Počet získaných sušenek: " + game.TotalCookies;
        }

        private void openUpgradesWindow(object sender, RoutedEventArgs e)
        {
            if(upgradeWindow is not null && !upgradeWindow.IsClosed)
            {
                return;
            }
            upgradeWindow = new UpgradeWindow(game);
            upgradeWindow.Show();
        }
    }
}