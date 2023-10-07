using MISApp.ViewModels.Base;

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
