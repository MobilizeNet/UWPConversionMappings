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
    public sealed partial class InputPomptUserControl : UserControl
    {
       
        public InputPomptUserControl(){
            InitializeComponent();
            }


        internal void setInputScope(Windows.UI.Xaml.Input.InputScope value)
        {           
            txtBox.InputScope = value;
        }

        public Windows.UI.Xaml.Input.InputScope getInputScope()
        {
            return txtBox.InputScope;
        }

        internal void setMessage (string value)
        {
            Message.Text = value;
            Message.Visibility = Visibility.Visible;
        }                    
        
        public string getMessage()
        {
            return Message.Text;
        }

        internal void setValue(string value)
        {
            txtBox.Text = value;
            txtBox.Visibility = Visibility.Visible;
        }

        public string getValue()
        {
            return txtBox.Text;
        }
    }
}
