using DotNET9Test.ViewModels.Settings;

namespace DotNET9Test.Views.Settings;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsPageViewModel settingsPageViewModel)
	{
		InitializeComponent();
        BindingContext = settingsPageViewModel;
    }
}