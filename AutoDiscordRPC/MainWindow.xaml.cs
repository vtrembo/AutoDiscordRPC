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

        public MainWindow()
        {       
            InitializeComponent();
        }
       
        private void addButtonClick(object sender, RoutedEventArgs e)
        {
            

             System.Diagnostics.Process process = System.Diagnostics.Process.Start(@"C:\Sweazy\FUN\Heroes 3\Hota\HotA_launcher.exe");
       
        }

       
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            // Environment.Exit(Environment.ExitCode);
        }
    }
}
