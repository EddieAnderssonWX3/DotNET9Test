using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET9Test.Models.Contacts
{
    public partial class MyUser : ObservableObject
    {
        [ObservableProperty]
        public string name = "";
        [ObservableProperty]
        public string profileImage = "";
        [ObservableProperty]
        public string initials = "";

        public MyUser(string name, string profileImage)
        {
            Name = name;
            ProfileImage = profileImage;
            Initials = "EA";
        }
    }
}
