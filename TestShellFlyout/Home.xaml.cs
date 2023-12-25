using System.Reflection;

namespace TestShellFlyout;

public partial class Home : ContentPage
{
	public Home()
	{
		
		InitializeComponent();
	}

    /// <summary>
    /// OnAppearing is called after the page is Created, Before it is Shown on Screen. we can override it.
    /// </summary>
    protected override void OnAppearing()
    {
        //do the regular stuff OnAppearing does
        base.OnAppearing();

        //do the the extra: go for each FlyoutItems in the Shell menu
        foreach (var x in Shell.Current.Items)
        {
            //check if this is the one we want to hide we are basing on  the convention that  name of the routing is the same as the Page name
            if(x.CurrentItem.CurrentItem.Route==nameof(MainPage)) {x.FlyoutItemIsVisible = false;}
            //change the visiblity of the flyout Item
            else x.FlyoutItemIsVisible = true;
        }
       
    }
}