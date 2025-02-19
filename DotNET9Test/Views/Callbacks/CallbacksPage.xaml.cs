using DotNET9Test.ViewModels.Callbacks;

namespace DotNET9Test.Views.Callbacks;

public partial class CallbacksPage : ContentPage
{
	public CallbacksPage(CallbacksPageViewModel callbacksPageViewModel)
	{
		InitializeComponent();
        BindingContext = callbacksPageViewModel;
    }
}