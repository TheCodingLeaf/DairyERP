using ReactiveUI;
using System.ComponentModel;

namespace DairyERP.ViewModels
{

    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public static MainWindowViewModel Instance { get; private set; }
        private ViewModelBase _contentViewModel;

        public LoginViewModel LoginView = new();

        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void SetViewModel(ViewModelBase model)
        {
            ContentViewModel = model;
        }

        public MainWindowViewModel()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            _contentViewModel = new LoginViewModel();

        }
    }
 
}
