
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestShellFlyout.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

       
        public ICommand LoginCommand {get;protected set;}
        public ICommand SignUpCommand { get; protected set; }

        public ICommand BackCommand { get; protected set; }

        public MainPageViewModel()
        {
            LoginCommand = new Command(async () => await Shell.Current.GoToAsync("Login"));
            SignUpCommand = new Command(async () => await Shell.Current.GoToAsync("SignUp"));
            BackCommand = new Command(async () => await Shell.Current.GoToAsync(".."));
        }

    }
}
