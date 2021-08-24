using AutoDiscordRPC.Core;
using System.Windows;
using System.Windows.Input;

namespace AutoDiscordRPC.MVVM.ViewModel
{
    public class NotifyIconViewModel
    {
        public ICommand ShowWindowCommand
        {
            get
            {
                return new DelegateCommand { CommandAction = () => Application.Current.MainWindow.Show() };
            }
        }

        public ICommand ExitApplicationCommand
        {
            get
            {
                return new DelegateCommand { CommandAction = () => Application.Current.Shutdown() };
            }
        }
    }
}
