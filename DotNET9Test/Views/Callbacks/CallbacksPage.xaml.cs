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
}