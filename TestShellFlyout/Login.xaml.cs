using TestShellFlyout.ViewModels;

namespace TestShellFlyout;

public partial class Login : ContentPage
{
	public Login(LoginPageViewModel vm)
	{
		this.BindingContext = vm;	
		InitializeComponent();
	}
}