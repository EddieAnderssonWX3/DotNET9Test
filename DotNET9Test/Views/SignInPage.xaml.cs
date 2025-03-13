namespace DotNET9Test.Views;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(Application.Current != null)
		{
            Application.Current.MainPage = new AppShell();
		}
    }
}