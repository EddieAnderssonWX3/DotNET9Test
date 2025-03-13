using DotNET9Test.ViewModels.Messages;
using DotNET9Test.Views.ActiveCalls;
using Microsoft.Maui.Controls;

namespace DotNET9Test.Views.Messages;

public partial class MessagesPage : ContentPage
{
	public MessagesPage(MessagesPageViewModel messagesPageViewModel)
	{
		InitializeComponent();
        BindingContext = messagesPageViewModel;
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Messages", true);
        }
    }

    public async Task GoToBlue()
    {
        /*await Shell.Current.GoToAsync($"{nameof(ActiveCallsPage)}", true);*/
        await Shell.Current.GoToAsync($"///{nameof(ActiveCallsPage)}");
    }
}