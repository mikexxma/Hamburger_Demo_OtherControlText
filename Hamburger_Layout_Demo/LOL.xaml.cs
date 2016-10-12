using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Layout_Demo
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LOL : Page
    {
        string[] lolTeams = { "ROSTigers","EDG","LGD","EG","FNC","SKT1","SAMSUNG"};
        public LOL()
        {
            this.InitializeComponent();
        }

        private void FlyoutButton_Click(object sender, RoutedEventArgs e)
        {
         //   MyFlyout.Hide();
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }

        private void MyAutoSuggestBox_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
           
        }

        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
           var teams = lolTeams.Where(p => p.StartsWith(sender.Text)).ToArray();
            MyAutoSuggestBox.ItemsSource = teams;
        }
    }
}
