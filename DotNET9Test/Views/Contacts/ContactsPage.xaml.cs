using DotNET9Test.ViewModels.Contacts;

namespace DotNET9Test.Views.Contacts;

public partial class ContactsPage : ContentPage
{
    private ContactsPageViewModel ContactsPageViewModel;
    public ContactsPage(ContactsPageViewModel contactsPageViewModel)
	{
		InitializeComponent();
		BindingContext = contactsPageViewModel;
        ContactsPageViewModel = contactsPageViewModel;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Contacts", true, "message_sent.png", new Command(async () => await ContactsPageViewModel.GoToActiveCallsPage()));
        }
    }
}