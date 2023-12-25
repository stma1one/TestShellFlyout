using TestShellFlyout.ViewModels;

namespace TestShellFlyout
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage(MainPageViewModel vm)
        {
            this.BindingContext = vm;
            InitializeComponent();
        }
    }

       
       
}