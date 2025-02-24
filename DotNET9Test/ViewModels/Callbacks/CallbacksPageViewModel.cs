using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.Models.ActiveCalls;
using DotNET9Test.Models.Callbacks;
using DotNET9Test.Views.Contacts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.Callbacks
{
    public partial class CallbacksPageViewModel : ObservableObject
    {
        public bool ShowBackButton = false;

        [ObservableProperty]
        public ObservableCollection<CallbackModel> callbackModels = new();
        public CallbacksPageViewModel()
        {
            for (var i = 0; i < 100; i++)
            {
                callbackModels.Add(new(i + 1, i + 1, i + 1, "caller " + i + 1, "reciver " + i + 1));
            }
        }

        [RelayCommand]
        public async Task GoToContactsAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(ContactsPage)}", true);
        }
    }
}
