using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.Views.ActiveCalls;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.Messages
{
    public partial class MessagesPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public string test = "EDDIE";
        public MessagesPageViewModel() 
        {
            
        }  
    }
}
