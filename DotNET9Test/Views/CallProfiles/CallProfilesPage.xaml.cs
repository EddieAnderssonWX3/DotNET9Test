using DotNET9Test.ViewModels.CallProfiles;

namespace DotNET9Test.Views.CallProfiles;

public partial class CallProfilesPage : ContentPage
{
	public CallProfilesPage(CallProfilesPageViewModel callProfilesPageViewModel)
	{
		InitializeComponent();
        BindingContext = callProfilesPageViewModel;
    }
}