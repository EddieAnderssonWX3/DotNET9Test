using DotNET9Test.ViewModels.ActiveCalls;

namespace DotNET9Test.Views.ActiveCalls;

public partial class ActiveCallsPage : ContentPage
{
	public ActiveCallsPage(ActiveCallsPageViewModel activeCallsPageViewModel)
	{
		InitializeComponent();
        BindingContext = activeCallsPageViewModel;
    }
}