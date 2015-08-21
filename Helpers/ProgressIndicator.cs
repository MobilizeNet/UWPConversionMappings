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
    public static class ProgressIndicator
    {
        public async static void ChangeVisibility(Windows.UI.ViewManagement.StatusBarProgressIndicator progressBar, bool visible)
        {
            if (visible)
            {
                await progressBar.ShowAsync();
            }
            else
            {
                await progressBar.HideAsync();
            }
        }
    }
}