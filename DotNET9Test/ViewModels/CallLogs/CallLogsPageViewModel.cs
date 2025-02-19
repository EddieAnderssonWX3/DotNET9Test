using CommunityToolkit.Mvvm.ComponentModel;
using DotNET9Test.Models.ActiveCalls;
using DotNET9Test.Models.CallLogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.CallLogs
{
    public partial class CallLogsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<CallLogModel> callLogModels = new();
        public CallLogsPageViewModel()
        {
            for (var i = 0; i < 100; i++)
            {
                CallLogModels.Add(new(i + 3, i + 3, i + 3, "caller " + i + 3, "reciver " + i + 3));
            }
        }
    }
}
