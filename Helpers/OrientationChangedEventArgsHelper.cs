
using System;
using Windows.UI.ViewManagement;

namespace WindowsPhoneUWP.UpgradeHelpers
{

  public class OrientationChangedEventArgsHelper : EventArgs
  {

    public ApplicationViewOrientation Orientation { get; }

    public OrientationChangedEventArgsHelper(ApplicationViewOrientation orientation)
        {
            this.Orientation = orientation;
        }
  }
}
