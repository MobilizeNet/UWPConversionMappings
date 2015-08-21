using System;
using Windows.UI.Xaml;

namespace WindowsPhoneUWP.UpgradeHelpers
{
  public class PrepareContainerForItemEventArgsHelper : EventArgs
  {
    public DependencyObject Element { get; private set; }

    public object Item { get; private set; }

	public PrepareContainerForItemEventArgsHelper(DependencyObject element, object item)
    {
      this.Element = element;
      this.Item = item;
    }
  }
}