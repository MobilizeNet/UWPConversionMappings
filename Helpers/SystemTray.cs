using System;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{

    // Summary:
    //     Provides the app the ability to retrieve device information from the local computer.
    public static class SystemTray
    {
        public async static void ChangeVisibility(bool visible)
        {
            if (visible)
            {
                await Windows.UI.ViewManagement.StatusBar.GetForCurrentView().ShowAsync();
            }
            else
            {
                await Windows.UI.ViewManagement.StatusBar.GetForCurrentView().HideAsync();
            }
        }
    }
}