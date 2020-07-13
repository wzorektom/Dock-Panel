using DockPanel.States.Navigators;
using DockPanel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DockPanel.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.FrontEndView:
                        _navigator.CurrentViewModel = new FrontEndViewModel();
                        break;
                    case ViewType.ServersView:
                        _navigator.CurrentViewModel = new ServerViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
