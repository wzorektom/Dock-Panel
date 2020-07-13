using System.Windows;
using System.Windows.Input;

namespace DockPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);


        }

        private void DockPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

      
    }

    

}
