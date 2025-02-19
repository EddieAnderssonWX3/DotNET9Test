using DotNET9Test.ViewModels.Messages;

namespace DotNET9Test.Views.Messages;

public partial class MessagesPage : ContentPage
{
	public MessagesPage(MessagesPageViewModel messagesPageViewModel)
	{
		InitializeComponent();
        BindingContext = messagesPageViewModel;
    }
}