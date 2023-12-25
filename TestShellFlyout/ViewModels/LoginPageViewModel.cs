using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestShellFlyout.ViewModels
{
    public class LoginPageViewModel:ViewModelBase
    {
        public ICommand NavigateToHomePage { get; protected set; }
        public LoginPageViewModel() 
        {
            NavigateToHomePage = new Command(async () => {
                
                try
                {
                    await Shell.Current.GoToAsync("///Home"); } 
                catch (Exception ex) {
                } });
        } 
    }
}
