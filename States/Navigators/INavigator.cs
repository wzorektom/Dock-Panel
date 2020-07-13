using DockPanel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DockPanel.States.Navigators
{
    public enum ViewType
    {
        FrontEndView,
        ServersView
    }
    public interface INavigator
    {
        BaseViewModel CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }

       
    }
}
