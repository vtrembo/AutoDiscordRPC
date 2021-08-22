using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;

namespace AutoDiscordRPC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Forms.NotifyIcon m_notifyIcon;
        private bool activeProcess = false;
        public MainWindow()
        {
            
            
            InitializeComponent();

            Thread t = new Thread(checkForProcess);
            t.IsBackground = true;
            t.Start();

            m_notifyIcon = new System.Windows.Forms.NotifyIcon();
            m_notifyIcon.BalloonTipText = "The app has been minimised. Click the tray icon to show.";
            m_notifyIcon.BalloonTipTitle = "The App";
            m_notifyIcon.Text = "The App";
           // m_notifyIcon.Icon = new System.Drawing.Icon("Images/github.ico");
            m_notifyIcon.Visible = true;
            m_notifyIcon.Click += new EventHandler(m_notifyIcon_Click);

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
        private void addButtonClick(object sender, RoutedEventArgs e)
        {
            

             System.Diagnostics.Process process = System.Diagnostics.Process.Start(@"C:\Sweazy\FUN\Heroes 3\Hota\HotA_launcher.exe");
       
        }

        private WindowState m_storedWindowState = WindowState.Normal;
        void OnStateChanged(object sender, EventArgs args)
        {
            if (WindowState == WindowState.Minimized)
            {
                Hide();
                if (m_notifyIcon != null)
                    m_notifyIcon.ShowBalloonTip(2000);
            }
            else
                m_storedWindowState = WindowState;
        }
        void OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            CheckTrayIcon();
        }

        void m_notifyIcon_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = m_storedWindowState;
        }
        void CheckTrayIcon()
        {
            ShowTrayIcon(!IsVisible);
        }

        void ShowTrayIcon(bool show)
        {
            if (m_notifyIcon != null)
                m_notifyIcon.Visible = show;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            m_notifyIcon.Dispose();
            m_notifyIcon = null;
            // Environment.Exit(Environment.ExitCode);
        }
    }
}
