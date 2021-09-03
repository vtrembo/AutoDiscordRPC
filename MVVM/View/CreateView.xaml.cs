using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoDiscordRPC.MVVM.View
{
    /// <summary>
    /// Interaction logic for CreateView.xaml
    /// </summary>
    public partial class CreateView : UserControl
    {
        public CreateView()
        {
            InitializeComponent();
        }
        private void ToggleButton1_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)(sender as ToggleButton).IsChecked)
            {
                Button1URL.IsEnabled = true;
                Button1Text.IsEnabled = true;
            }
            else
            {
                Button1URL.IsEnabled = false;
                Button1Text.IsEnabled = false;
            }
        }
        private void ToggleButton2_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)(sender as ToggleButton).IsChecked)
            {
                Button2URL.IsEnabled = true;
                Button2Text.IsEnabled = true;
            }
            else
            {
                Button2URL.IsEnabled = false;
                Button2Text.IsEnabled = false;
            }
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Process"; // Default file name
            dialog.DefaultExt = ".exe"; // Default file extension
            dialog.Filter = "Exe files (.exe)|*.exe"; // Filter files by extension

            // Show open file dialog box
            bool? result = dialog.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                Match match = Regex.Match(dialog.FileName, @"(?<process>[\w\.-]*)\.exe");
                if (match.Success)
                {
                    BrowseLable.Content = match.Groups[1].Value;
                }
            }
        }

        private void ToggleButtonAuto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDevPortal_Click(object sender, RoutedEventArgs e)
        {
            string browserName = GetSystemDefaultBrowser();
            try
            {
                Process.Start(new ProcessStartInfo(browserName, "https://discord.com/developers/applications"));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private string GetSystemDefaultBrowser()
        {
            string name = string.Empty;
            RegistryKey regKey = null;
            try
            {
                var regDefault = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.htm\\UserChoice", false);
                var stringDefault = regDefault.GetValue("ProgId");

                regKey = Registry.ClassesRoot.OpenSubKey(stringDefault + "\\shell\\open\\command", false);
                name = regKey.GetValue(null).ToString().ToLower().Replace("" + (char)34, "");

                if (!name.EndsWith("exe"))
                    name = name.Substring(0, name.LastIndexOf(".exe") + 4);
            }
            catch (Exception ex)
            {
                name = string.Format("ERROR: An exception of type: {0} occurred in method: {1} in the following module: {2}", ex.GetType(), ex.TargetSite, this.GetType());
            }
            finally
            {
                if (regKey != null)
                    regKey.Close();
            }
            return name;
        }

    }
}
