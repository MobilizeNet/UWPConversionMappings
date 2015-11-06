using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.StartScreen;
using Windows.UI.Xaml;

namespace WindowsPhoneUWP.UpgradeHelpers
{
	public class LocalNavigationHelper
	{
		public static string GetDestinationXamlPage(DependencyObject obj)
		{

			return (string)obj.GetValue(DestinationXamlPageProperty);
		}

		private static void LocalNavigationHelper_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
		{
			WindowsPhoneUWP.UpgradeHelpers.NavigationHelper.NavigateTo(new Uri(GetDestinationXamlPage((DependencyObject)sender), UriKind.Relative));
		}

		public static void SetDestinationXamlPage(DependencyObject obj, string value)
		{

			((UIElement)obj).Tapped -= LocalNavigationHelper_Tapped;
			if (!string.IsNullOrWhiteSpace(value))
			{
				((UIElement)obj).Tapped += LocalNavigationHelper_Tapped;
			}
			obj.SetValue(DestinationXamlPageProperty, value);
		}

		public static readonly DependencyProperty DestinationXamlPageProperty =
			DependencyProperty.RegisterAttached("DestinationXamlPage", typeof(string), typeof(UIElement), new PropertyMetadata(""));
	}
}
