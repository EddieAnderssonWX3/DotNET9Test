using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotNET9Test.Models.Contacts;
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
        public ContactsPageViewModel()
        {
            for (var i = 0; i < 100; i++)
            {
                ContactModels.Add(new(i + 3, i + 3, i + 3, "caller " + i + 3, "reciver " + i + 3));
            }
        }

        [RelayCommand]
        public async Task ReOrderAppShellTabBar()
        {
            if (Shell.Current is AppShell shell)
            {
                await shell.ReOrderTabBar();
            }
        }
    }
}
