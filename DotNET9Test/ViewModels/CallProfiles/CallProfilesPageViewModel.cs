using CommunityToolkit.Mvvm.ComponentModel;
using DotNET9Test.Models.CallProfiles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.CallProfiles
{
    public partial class CallProfilesPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<CallProfileModel> callProfileModels = new();
        public CallProfilesPageViewModel()
        {
            for (var i = 0; i < 100; i++)
            {
                CallProfileModels.Add(new(i + 3, i + 3, i + 3, "caller " + i + 3, "reciver " + i + 3));
            }
        }
    }
}
