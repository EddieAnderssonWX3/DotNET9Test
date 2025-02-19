using DotNET9Test.ViewModels.Voicemails;

namespace DotNET9Test.Views.Voicemails;

public partial class VoicemailsPage : ContentPage
{
	public VoicemailsPage(VoicemailsPageViewModel voicemailsPageViewModel)
	{
		InitializeComponent();
        BindingContext = voicemailsPageViewModel;
    }
}