using System;

namespace WindowsPhoneUWP.UpgradeHelpers
{
  public class NavigationEventArgsHelper : EventArgs
  {
    public object Item { get; private set; }

    internal NavigationEventArgsHelper(object item)
    {
      this.Item = item;
    }
  }
}