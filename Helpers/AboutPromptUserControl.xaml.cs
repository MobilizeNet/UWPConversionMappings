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
    public sealed partial class AboutPromptUserControl : UserControl
    {
        public AboutPromptUserControl(){
            InitializeComponent();
            }       

        internal void setBody(object value)
        {
            Body.Content = value;
            Body.Visibility = Visibility.Visible;
        }

        internal void setFooter(object value)
        {
            Footer.Content = value;
            Footer.Visibility = Visibility.Visible;
        }

        internal void setTitle(string value)
        {
            Title.Text = value;
            Title.Visibility = Visibility.Visible;
        }

        internal void setVersionNumber(string value)
        {
            this.VersionNumber.Text = value;
            VersionNumber.Visibility = Visibility.Visible;
        }
        internal void setWaterMark(object value)
        {
            WaterMark.Content = value;
            WaterMark.Visibility = Visibility.Visible;
        }

        internal void setAuthorName(string value)
        {
            AuthorName.Text = value;
            AuthorName.Visibility = Visibility.Visible;
        }

        internal void setEmailAddress(string value)
        {
            EmailAddress.Text = value;
            EmailAddress.Visibility = Visibility.Visible;
        }

        internal void setRole(string value)
        {
            Role.Text = value;
            Role.Visibility = Visibility.Visible;
        }

        internal void setWebSiteUrl(string value)
        {
            WebSiteUrl.Text = value;
            WebSiteUrl.Visibility = Visibility.Visible;
        }
    }
}
