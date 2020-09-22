using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media.Animation;

namespace CustomControlPlayground.GUI.Views
{
    /// <summary>
    /// Interaktionslogik für UserControl1.xaml
    /// </summary>
    public partial class HamburgerMenu : UserControl
    {
        public HamburgerMenu()
        {
            InitializeComponent();
        }

        private void MenuToggleButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ToggleButton hamburgerMenuButton = (ToggleButton)sender;
            if (hamburgerMenuButton.IsChecked == true)
            {
                Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
                sb.Begin();
            }
            else
            {
                Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
                sb.Begin();
            }
        }
    }
}
