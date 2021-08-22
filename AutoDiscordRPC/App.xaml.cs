using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace AutoDiscordRPC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
/*        public App()
        {
            _notifyIcon = new Forms.NotifyIcon();
        }*/

        protected override void OnStartup(StartupEventArgs e)
        {



            MainWindow = new MainWindow();
            MainWindow.Show();
            Thread t = new Thread(checkForProcess);
            t.IsBackground = true;
            t.Start();
            base.OnStartup(e);
        }
        private void checkForProcess()
        {
            while (true)
            {
                bool isRunning = Process.GetProcessesByName("HotA_launcher")
                    .FirstOrDefault(p => p.MainModule.FileName.StartsWith(@"C:\Sweazy\FUN\Heroes 3\Hota")) != default(Process);
                if (isRunning)
                {
                    Process process = Process.Start("cmd.exe");
                }
                Thread.Sleep(1000);
            }

        }
    }
}
