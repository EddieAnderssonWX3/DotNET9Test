using CommunityToolkit.Maui.Views;

namespace DotNET9Test.Popups.MoreTabs;

public partial class MoreTabsPopup : Popup
{
	
	public MoreTabsPopup(View anchorView)
	{
		InitializeComponent();
		BindingContext = new MoreTabsPopupViewModel();
    }
}