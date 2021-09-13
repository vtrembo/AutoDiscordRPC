using Hardcodet.Wpf.TaskbarNotification;
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
    public partial class App : Application
    {

        private TaskbarIcon notifyIcon;
        protected override void OnStartup(StartupEventArgs e)
        {
            // System.Diagnostics.Process process = System.Diagnostics.Process.Start(@"C:\Sweazy\FUN\Heroes 3\Hota\HotA_launcher.exe");
            notifyIcon = (TaskbarIcon)FindResource("NotifyIcon");
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
                /*                bool isRunning = Process.GetProcessesByName("HotA_launcher")
                                    .FirstOrDefault(p => p.MainModule.FileName.StartsWith(@"C:\Sweazy\FUN\Heroes 3\Hota")) != default(Process);
                                if (isRunning)
                                {
                                    Process process = Process.Start("cmd.exe");
                                }*/
                Process[] pname = Process.GetProcessesByName("ColorPix");
                if (pname.Length != 0) {
                    Process process = Process.Start("cmd.exe");
                }
                Thread.Sleep(1000);
            }

        }
    }
}
