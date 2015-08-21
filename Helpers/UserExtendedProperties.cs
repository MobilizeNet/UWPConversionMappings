
using System;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers {
    static class UserExtendedPropertiesHelper
    {

		internal static bool TryGetValue(string argument, out object result)
		{
			result = (Object)Windows.System.UserProfile.AdvertisingManager.AdvertisingId;
			if(result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
		}
    }
}