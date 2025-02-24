using DotNET9Test.ViewModels;

namespace DotNET9Test.Views;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel loadingPageViewModel)
	{
		InitializeComponent();
        BindingContext = loadingPageViewModel;
    }
}