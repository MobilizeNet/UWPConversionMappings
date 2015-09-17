using Windows.ApplicationModel.DataTransfer;
using System;
using System.Threading.Tasks;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{

    // Summary:
    //     Provides access to some clipboard functions unavailable on Windows Universal Apps
    public static class Clipboard
    {
        public static void SetText(string text)
        {
            var dataPackage = new DataPackage();
            dataPackage.SetText(text);
            Windows.ApplicationModel.DataTransfer.Clipboard.SetContent(dataPackage);
        }

        public async static Task<string> GetText()
        {
            string textToReturn = string.Empty;
            var dataPackageView = Windows.ApplicationModel.DataTransfer.Clipboard.GetContent();
            if (dataPackageView.Contains(StandardDataFormats.Text))
            {
                textToReturn = await dataPackageView.GetTextAsync();                    
            }
            return textToReturn;
        }
    }
}