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
                return new DelegateCommand
                {
                    CanExecuteFunc = () => Application.Current.MainWindow == null,
                    CommandAction = () =>
                    {
                        Application.Current.MainWindow = new MainWindow();
                        Application.Current.MainWindow.Show();
                    }
                };
            }
        }

        /// <summary>
        /// Hides the main window. This command is only enabled if a window is open.
        /// </summary>
        public ICommand HideWindowCommand
        {
            get
            {
                return new DelegateCommand
                {
                    CommandAction = () => Application.Current.MainWindow.Close(),
                    CanExecuteFunc = () => Application.Current.MainWindow != null
                };
            }
        }


        /// <summary>
        /// Shuts down the application.
        /// </summary>
        public ICommand ExitApplicationCommand
        {
            get
            {
                return new DelegateCommand { CommandAction = () => Application.Current.Shutdown() };
            }
        }
        /*    /// <summary>
            /// Shows a window, if none is already open.
            /// </summary>
            public ICommand ShowWindowCommand
            {
                get
                {
                    return new RelayCommand
                    {
                        _canExecute = () => Application.Current.MainWindow == null,
                        _execute = () =>
                        {
                            Application.Current.MainWindow = new MainWindow();
                            Application.Current.MainWindow.Show();
                        }
                    };
                }
            }

            /// <summary>
            /// Hides the main window. This command is only enabled if a window is open.
            /// </summary>
            public ICommand HideWindowCommand
            {
                get
                {
                    return new RelayCommand
                    {
                        _execute = () => Application.Current.MainWindow.Close(),
                        _canExecute = () => Application.Current.MainWindow != null
                    };
                }
            }


            /// <summary>
            /// Shuts down the application.
            /// </summary>
            public ICommand ExitApplicationCommand
            {
                get
                {
                    return new DelegateCommand { CommandAction = () => Application.Current.Shutdown() };
                }
            }*/
    }
}
