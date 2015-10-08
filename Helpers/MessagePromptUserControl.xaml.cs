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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace WindowsPhoneUWP.UpgradeHelpers
{
    public sealed partial class MessagePomptUserControl : UserControl
    {
       
        public MessagePomptUserControl(){
            InitializeComponent();
            }       

        internal void setBody(object value)
        {
            Body.Content = value;
            Body.Visibility = Visibility.Visible;
        }      
        
        internal void setButton(System.Collections.ObjectModel.ObservableCollection<Windows.UI.Xaml.Controls.Button> value)
        {
            Buttons.Children.Clear();
            foreach (Windows.UI.Xaml.Controls.Button item in value)
            {
                Buttons.Children.Add(item);
            }
            
            Buttons.Visibility = Visibility.Visible;
        }
        
    }
}
