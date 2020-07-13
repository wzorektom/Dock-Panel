using DockPanel.ViewModel;
using System.Windows;

namespace DockPanel
{
    /// <summary>
    /// The View Model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {



        private Window _window;
        public WindowViewModel(Window window)
        {
            _window = window;
        }



        public string TopBanner { get; } = "Dock Panel";

        public int TopBannerHeight { get; } = 25;





    }
}
