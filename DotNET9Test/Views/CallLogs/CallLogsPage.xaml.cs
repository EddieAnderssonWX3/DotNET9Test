using DotNET9Test.ViewModels.CallLogs;

namespace DotNET9Test.Views.CallLogs;

public partial class CallLogsPage : ContentPage
{
	public CallLogsPage(CallLogsPageViewModel callLogsPageViewModel)
	{
		InitializeComponent();
        BindingContext = callLogsPageViewModel;
    }
}