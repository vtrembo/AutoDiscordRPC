using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
