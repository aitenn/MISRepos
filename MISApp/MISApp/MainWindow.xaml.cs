using MISApp.ViewModels;
using System.Windows;

namespace MISApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.viewModel = new MainWindowViewModel();
            this.viewModel.ActiveViewModel = new HomePageViewModel();
            this.DataContext = this.viewModel;
        }

        private void GradebooksClick(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new GradebookViewModel();

        private void RegistersClick(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new RegisterViewModel();

        private void FeedbackClick(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new FeedbackViewModel();

        private void MoreClick(object sender, RoutedEventArgs e) => this.viewModel.ActiveViewModel = new MoreViewModel();
     
    }
}
