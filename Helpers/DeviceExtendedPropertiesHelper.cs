
using System;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers {
    static class DeviceExtendedPropertiesHelper
    {
        internal static Object GetValue( string argument)
        {
            switch (argument)
            {
                case "ApplicationCurrentMemoryUsage":
                    return (Object)Windows.System.MemoryManager.AppMemoryUsage;
                case "DeviceFirmwareVersion":
                    return (Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemFirmwareVersion;
                case "DeviceHardwareVersion":
                    return (Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemHardwareVersion;
                case "DeviceManufacturer":
                    return (Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemManufacturer;
                case "DeviceName":
                    return ((Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemProductName);
                default:
                    ArgumentOutOfRangeException argumentOutOfRangeException = new ArgumentOutOfRangeException();
                    throw argumentOutOfRangeException;

            }
        }

		internal static bool TryGetValue(string argument, out object result)
		{
			switch (argument)
			{
				case "ApplicationCurrentMemoryUsage":
					result = (Object)Windows.System.MemoryManager.AppMemoryUsage;
					return true;
				case "DeviceFirmwareVersion":
					result = (Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemFirmwareVersion;
					return true;
				case "DeviceHardwareVersion":
					result = (Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemHardwareVersion;
					return true;
				case "DeviceManufacturer":
					result = (Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemManufacturer;
					return true;
				case "DeviceName":
					result = ((Object)(new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation()).SystemProductName);
					return true;
				default:
					result = null;
					return false;
			}
		}
    }
}