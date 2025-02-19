using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.Models.CallProfiles
{
    public partial class CallProfileModel : ObservableObject
    {
        [ObservableProperty]
        public int callId;
        [ObservableProperty]
        public int callerId;
        [ObservableProperty]
        public int reciverId;
        [ObservableProperty]
        public string callerName;
        [ObservableProperty]
        public string reciverName;

        public CallProfileModel(int callId, int callerId, int reciverId, string callerName, string reciverName)
        {
            CallId = callId;
            CallerId = callerId;
            ReciverId = reciverId;
            CallerName = callerName;
            ReciverName = reciverName;
        }
    }
}
