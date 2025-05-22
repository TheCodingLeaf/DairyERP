using ReactiveUI;
using System;
using System.Reactive;
using DairyERP.ViewModels;

namespace DairyERP.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> CheckLoginCommand { get; }

        private string _UsernameInput;
        public string UsernameInput
        {
            get => _UsernameInput;
            set => this.RaiseAndSetIfChanged(ref _UsernameInput, value);
        }

        public LoginViewModel()
        {
            // Initialiser kommandoen og bind den til metoden
            CheckLoginCommand = ReactiveCommand.Create(CheckLogin);
        }

        private void CheckLogin()
        {
            string correctUsername = "Test123";

            if (UsernameInput == correctUsername)
            {
                HomePageBtn();
            }
            else
            {
                // TODO: Giv fejlbesked
            }
        }

        private void HomePageBtn()
        {
            MainWindowViewModel.Instance.SetViewModel(new HomePageViewModel());
        }
    }
}