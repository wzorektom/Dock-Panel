using DockPanel.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DockPanel.ViewModel
{
    public class FrontEndViewModel : BaseViewModel
    {
        public ICommand XTest { get; }

        public ICommand YTest { get;}

        public FrontEndViewModel()
        {
            XTest = new RelayCommand(XDocumentation);
            YTest = new RelayCommand(YDocumentation);

        }

        public void XDocumentation(object obj)
        {
            Process.Start(@"file:///\\xxxxxx");
        }

        public void YDocumentation(object obj)
        {
            Process.Start(@"file:///\\xxxxxx");
        }


    }
}
