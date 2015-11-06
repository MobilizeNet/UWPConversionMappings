
using System;
using Windows.System.Display;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{

	public class PhoneApplicationServiceHelper
	{

        private static DisplayRequest AppDisplayRequest;
        private static long DisplayRequestRefCount = 0;
        private const long LongMax = 2147483647L;
        private static string _idleDetectionMode = string.Empty;

        public static string IdleDetectionMode
        {
            get { return _idleDetectionMode; }
        }

		public static void UserIdleDetectionMode(IdleDetectionModeHelper argument)
		{
			if (argument == IdleDetectionModeHelper.Enabled)
            {
                Activate();
                DeActivate();
                _idleDetectionMode = "Enabled";
            }
            else
            {
                DeActivate();
                _idleDetectionMode = "Disabled";
            }
        }

        private static void Activate()
        {
            if (AppDisplayRequest == null)
            {

                // This call creates an instance of the displayRequest object
                AppDisplayRequest = new DisplayRequest();
            }

            // This call activates a display-required request. If successful, 
            // the screen is guaranteed not to turn off automatically due to user inactivity.	
            if (DisplayRequestRefCount < LongMax)
            {
                AppDisplayRequest.RequestActive();
                DisplayRequestRefCount++;
                System.Diagnostics.Debug.WriteLine("Display request activated (" + DisplayRequestRefCount + ")");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error: Exceeded maximum display request active instant count (" + DisplayRequestRefCount + ")");
            }
        }

        private static void DeActivate()
        {
            if (AppDisplayRequest != null && DisplayRequestRefCount > 0)
            {

                // This call de-activates the display-required request. If successful, the screen
                // might be turned off automatically due to a user inactivity, depending on the
                // power policy settings of the system. The requestRelease method throws an exception 
                // if it is called before a successful requestActive call on this object.
                AppDisplayRequest.RequestRelease();
                DisplayRequestRefCount--;
                System.Diagnostics.Debug.WriteLine("Display request released (" + DisplayRequestRefCount + ")");
            }
			else
            {
                System.Diagnostics.Debug.WriteLine("No existing active display request instance to be released");
            }
		}

	}
}