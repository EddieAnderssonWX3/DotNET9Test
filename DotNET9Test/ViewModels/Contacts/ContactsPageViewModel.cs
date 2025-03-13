using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.Models.Contacts;
using DotNET9Test.Services;
using DotNET9Test.Views.ActiveCalls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.Contacts
{
    public partial class ContactsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<ContactModel> contactModels = new();

        public List<ContactModel> ContactData = new();
        public ContactsPageViewModel()
        {
            _ = Task.Run(() =>
            {
                for (var i = 0; i < 50; i++)
                {
                    ContactModel newContact = new(i + 1, i + 1, i + 1, "caller " + i + 1, "reciver " + i + 1);
                    ContactData.Add(newContact);
                    if(i < 20)
                    {
                        ContactModels.Add(newContact);
                    }
                }
            }); 
        }

        [RelayCommand]
        public async Task ReOrderAppShellTabBar()
        {
            if (Shell.Current is AppShell shell)
            {
                await shell.ReOrderTabBar();
                /*await Shell.Current.GoToAsync($"{nameof(ActiveCallsDetailsPage)}", true);*/
            }
        }
        
        [RelayCommand]
        public async Task LoadMoreContacts()
        {
            await Task.Run(() =>
            {

                int lastIndex = ContactModels.Count - 1;
                int numberToGet = ContactData.Count - lastIndex + 1 >= 20 ? 20 : ContactData.Count - ContactModels.Count;
                List<ContactModel> chunkToAdd = ContactData.GetRange(lastIndex + 1, numberToGet);

                foreach (ContactModel contactModel in chunkToAdd)
                {
                    ContactModels.Add(contactModel);
                }
            });
        }

        public async Task GoToActiveCallsPage()
        {
            if (Shell.Current is AppShell shell)
            {
                await Shell.Current.GoToAsync($"{nameof(ActiveCallsDetailsPage)}", true);
            }
        }

        [RelayCommand]
        public async Task ToggleLoadingBar()
        {
            await Task.Run(() =>
            {
                bool currentState = AppShellService.AppShellViewModel.ShowLoadingBar;
                AppShellService.AppShellViewModel.ToggleLoadingBar(!currentState);
            });
        }

        [RelayCommand]
        public async Task ToggleCallWindow()
        {
            await Task.Run(() =>
            {
                bool currentState = AppShellService.AppShellViewModel.ShowCallWindow;
                AppShellService.AppShellViewModel.ToggleCallWindow(!currentState);
            });
        }

        [RelayCommand]
        public async Task SetLoadingBarText()
        {
            await Task.Run(() =>
            {
                AppShellService.AppShellViewModel.LoadingBarText = "HELLO WORLD"; 
            });
        }
    }
}
