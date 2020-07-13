using DockPanel.Commands;
using DockPanel.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DockPanel.States.Navigators
{
    public class Navigator : BaseViewModel, INavigator
    {


        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set 
            { 
                currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);

       
    }
}
