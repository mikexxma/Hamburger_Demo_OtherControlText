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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger_Layout_Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            GameSpliteView.IsPaneOpen = !GameSpliteView.IsPaneOpen;
        }

        private void GameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SC2March.IsSelected)
            {
                if (GameSpliteView.IsPaneOpen)
                {
                    GameSpliteView.IsPaneOpen = !GameSpliteView.IsPaneOpen;
                } 
                GameFrame.Navigate(typeof(SC2));
            }
            else if (LOLMarch.IsSelected)
            {
                if (GameSpliteView.IsPaneOpen)
                {
                    GameSpliteView.IsPaneOpen = !GameSpliteView.IsPaneOpen;
                }
                GameFrame.Navigate(typeof(LOL));
            }
            else if (STFVMarch.IsSelected)
            {
                if (GameSpliteView.IsPaneOpen)
                {
                    GameSpliteView.IsPaneOpen = !GameSpliteView.IsPaneOpen;
                }
                GameFrame.Navigate(typeof(STFV));
            }
        }
    }
}
