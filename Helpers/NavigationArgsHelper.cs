using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.StartScreen;

namespace WindowsPhoneUWP.UpgradeHelpers
{
	public static class NavigationArgsHelper
	{
		public static Uri GetAsNavigationUri(this Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs navigationArgs)
		{
			return new Uri("/" + navigationArgs.SourcePageType.Name + "?" + Convert.ToString(navigationArgs.Parameter));
		}
	}
}
