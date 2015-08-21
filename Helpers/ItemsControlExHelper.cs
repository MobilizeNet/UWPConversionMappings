using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WindowsPhoneUWP.UpgradeHelpers
{
  public class ItemsControlExHelper : ItemsControl
  {
    public event EventHandler<PrepareContainerForItemEventArgsHelper> PrepareContainerForItem;

    protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
    {
      base.PrepareContainerForItemOverride(element, item);
      this.OnPrepareContainerForItem(new PrepareContainerForItemEventArgsHelper(element, item));
    }

    protected void OnPrepareContainerForItem(PrepareContainerForItemEventArgsHelper args)
    {
      if (this.PrepareContainerForItem == null)
        return;
      this.PrepareContainerForItem((object) this, args);
    }
  }
}