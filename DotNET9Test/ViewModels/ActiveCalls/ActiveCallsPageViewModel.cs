using CommunityToolkit.Mvvm.ComponentModel;
using DotNET9Test.Models.ActiveCalls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.ActiveCalls
{
    public partial class ActiveCallsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<ActiveCallModel> activeCallModels = new();
        public ActiveCallsPageViewModel()
        {
            for (var i = 0; i < 100; i++)
            {
                ActiveCallModels.Add(new(i+1, i+1, i+1, "caller " + i+1, "reciver " + i + 1));
                Console.WriteLine(ActiveCallModels[i].CallId);
            }
        }
    }
}
