using CommunityToolkit.Mvvm.ComponentModel;
using DotNET9Test.Views.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.ViewModels.Contacts
{
    public partial class ContactDetailsViewModel : ObservableObject
    {
        public string MyUser = "EDDIE HALLÅ";

        public ContactDetailsViewModel()
        {

        }

        public async Task GoToMessagesPage(object myUser)
        {
            if (Shell.Current is AppShell shell)
            {
                Console.WriteLine(myUser);
                await Shell.Current.GoToAsync($"{nameof(MessagesPage)}", true);
            }
        }
    }
}
