using AutoDiscordRPC.MVVW.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiscordRPC.MVVW.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<Presence> Presences { get; set; }

        public MainViewModel()
        {
            Presences = new ObservableCollection<Presence>();

            Presences.Add(new Presence
            {
                Name = "Hello",
                Details = "World",
                ImageSource = "https://i.imgur.com/dnPKCl9.png"

            });
            Presences.Add(new Presence
            {
                Name = "Hello",
                Details = "There",
                ImageSource = "https://i.imgur.com/n6ujM4H.png"
            });
            Presences.Add(new Presence
            {
                Name = "Hello",
                Details = "World",
                ImageSource = "Images/вал2.png"
            });
        }
    }
}
