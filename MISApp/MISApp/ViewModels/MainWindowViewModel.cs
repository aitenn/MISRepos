using MISApp.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MISApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase activeViewModel;

        public ViewModelBase ActiveViewModel 
        { 
            get => activeViewModel; 
            set => base.PropertyChangeMethod(out activeViewModel, value); 
        }
    }
}
