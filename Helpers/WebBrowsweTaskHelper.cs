
using System;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers {
    public class WebBrowserTaskHelper
    {
        public Uri Uri { get; internal set; }

        internal WebBrowserTaskHelper()
        {
            Uri = new Uri("http://http://www.windowsphone.com/en-US/how-to/wp8/apps/internet-explorer-start");
        }

        internal async void Show()
        {
            await Windows.System.Launcher.LaunchUriAsync(Uri);
        }
    }
}