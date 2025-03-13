using CommunityToolkit.Maui.PlatformConfiguration.AndroidSpecific;
using DotNET9Test.ViewModels.Callbacks;
using Microsoft.Maui.Controls;

namespace DotNET9Test.Views.Callbacks;

public partial class CallbacksPage : ContentPage
{
	public CallbacksPage(CallbacksPageViewModel callbacksPageViewModel)
	{
		InitializeComponent();
        BindingContext = callbacksPageViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Callbacks", true);
        }
    }
}