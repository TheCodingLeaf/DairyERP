using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyERP.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {

        }

        private string _UsernameInput;
        public string UsernameInput
        {
            get => _UsernameInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _UsernameInput, value, nameof(UsernameInput));
            }
        }

       

        public void CheckLogin()
        {
            string username = "Test123";

            if(UsernameInput == username)
            {
                HomePageBtn();
            }
            else
            {

            }
        }

        //Goes to HomePage 
        public void HomePageBtn()
        {
            MainWindowViewModel.Instance.SetViewModel(new HomePageViewModel());
        }
    }
}
