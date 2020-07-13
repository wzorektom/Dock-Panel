using System.Windows;
using System.Windows.Controls;


namespace DockPanel.Controls
{
    /// <summary>
    /// Interaction logic for NavPan.xaml
    /// </summary>
    public partial class NavPan : UserControl
    {
        public NavPan()
        {
            InitializeComponent();
           
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
    }
}
