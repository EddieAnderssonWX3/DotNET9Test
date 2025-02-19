using DotNET9Test.ViewModels.Contacts;

namespace DotNET9Test.Views.Contacts;

public partial class ContactsPage : ContentPage
{
	public ContactsPage(ContactsPageViewModel contactsPageViewModel)
	{
		InitializeComponent();
		BindingContext = contactsPageViewModel;
	}
}