using System;
using System.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Windows.Input;
using Windows.UI.Xaml.Input;

namespace WindowsPhoneUWP.UpgradeHelpers
{
  public class NavigationListHelper : Control
  {
	  public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(NavigationListHelper), new PropertyMetadata((PropertyChangedCallback)null));
	  public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(NavigationListHelper), new PropertyMetadata((PropertyChangedCallback)null));
    private bool _manipulationDeltaStarted;

    public IEnumerable ItemsSource
    {
      get
      {
        return (IEnumerable) this.GetValue(NavigationListHelper.ItemsSourceProperty);
      }
      set
      {
        this.SetValue(NavigationListHelper.ItemsSourceProperty, (object) value);
      }
    }

    public DataTemplate ItemTemplate
    {
      get
      {
        return (DataTemplate) this.GetValue(NavigationListHelper.ItemTemplateProperty);
      }
      set
      {
        this.SetValue(NavigationListHelper.ItemTemplateProperty, (object) value);
      }
    }

    public event EventHandler<NavigationEventArgsHelper> Navigation;

    public NavigationListHelper()
    {
      this.DefaultStyleKey = (object) typeof (NavigationListHelper);
    }

    protected override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      (this.GetTemplateChild("itemsControl") as ItemsControlExHelper).PrepareContainerForItem += new EventHandler<PrepareContainerForItemEventArgsHelper>(this.ItemsControl_PrepareContainerForItem);
    }

    private void ItemsControl_PrepareContainerForItem(object sender, PrepareContainerForItemEventArgsHelper e)
    {
      UIElement uiElement = e.Element as UIElement;
            uiElement.PointerReleased += UiElement_PointerReleased;
            uiElement.ManipulationStarted += UiElement_ManipulationStarted;
            uiElement.ManipulationDelta += UiElement_ManipulationDelta; 
    }

        private void UiElement_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            this._manipulationDeltaStarted = true;
        }

        private void UiElement_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            this._manipulationDeltaStarted = false;
        }

        private void UiElement_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            if (this._manipulationDeltaStarted)
                return;
            this.OnNavigation(new NavigationEventArgsHelper((sender as FrameworkElement).DataContext));
        }







    protected void OnNavigation(NavigationEventArgsHelper args)
    {
      if (this.Navigation == null)
        return;
      this.Navigation((object) this, args);
    }
  }
}