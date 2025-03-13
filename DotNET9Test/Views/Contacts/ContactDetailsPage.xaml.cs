using DotNET9Test.ViewModels.Contacts;

namespace DotNET9Test.Views.Contacts;

public partial class ContactDetailsPage : ContentPage
{
    private ContactDetailsViewModel ContactDetailsViewModel;
    public ContactDetailsPage(ContactDetailsViewModel contactDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = contactDetailsViewModel;
        ContactDetailsViewModel = contactDetailsViewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (Shell.Current is AppShell shell)
        {
            shell.AppShellViewModel.UpdateShellTopNavBar("Contact Details", false, "dotsblue.png", new Command(async () => await ContactDetailsViewModel.GoToMessagesPage(ContactDetailsViewModel.MyUser)));
        }
    }
}