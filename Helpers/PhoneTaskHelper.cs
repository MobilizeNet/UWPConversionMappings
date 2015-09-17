
using System;
using Windows.ApplicationModel.Calls;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace UpgradeHelpers
{
	public class PhoneTaskHelper
	{
		public string DisplayName { get; internal set; }
		public string PhoneNumber { get; internal set; }

		public PhoneTaskHelper()
		{
			DisplayName = "";
			PhoneNumber = "";
		}

		public void Show()
		{
			PhoneCallManager.ShowPhoneCallUI(PhoneNumber, DisplayName);
		}
	}
}
