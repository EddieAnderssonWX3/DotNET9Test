using DotNET9Test.ViewModels.RecordedCalls;

namespace DotNET9Test.Views.RecordedCalls;

public partial class RecordedCallsPage : ContentPage
{
	public RecordedCallsPage(RecordedCallsPageViewModel recordedCallsPageViewModel)
	{
		InitializeComponent();
        BindingContext = recordedCallsPageViewModel;
    }
}