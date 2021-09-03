using AutoDiscordRPC.Core;
using AutoDiscordRPC.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDiscordRPC.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CreateViewCommand { get; set; }
        public ObservableCollection<Presence> Presences { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public CreateViewModel CreateVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView;  }
            set
            {
                _currentView = value;
                OnPropertyChanged();             
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CreateVM = new CreateViewModel();
            CurrentView = HomeVM;

            CreateViewCommand = new RelayCommand(o => 
            {
                CurrentView = CreateVM;
            });

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

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
                ImageSource = "/Assets/auto.png"
            });
            Presences.Add(new Presence
            {
                Name = "Hello",
                Details = "World",
                ImageSource = "https://i.imgur.com/j1Q4azn.png"
            });
        }
    }
}
