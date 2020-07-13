using DockPanel.States.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DockPanel.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
