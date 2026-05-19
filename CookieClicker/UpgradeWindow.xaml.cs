using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CookieClicker
{
    /// <summary>
    /// Interakční logika pro UpgradeWindow.xaml
    /// </summary>
    public partial class UpgradeWindow : Window
    {
        Game game;
        public bool IsClosed { get; private set; }

        public UpgradeWindow(Game game)
        {
            InitializeComponent();
            this.game = game;


            UpgradeGrid.Children.Add(new Label{Content= "test", VerticalAlignment=VerticalAlignment.Center, HorizontalAlignment=HorizontalAlignment.Center});
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            IsClosed = true;
        }
    }
}
