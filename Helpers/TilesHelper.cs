using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.StartScreen;

namespace WindowsPhoneUWP.UpgradeHelpers
{
	public static class TilesHelper
	{
		/// <summary>
		///   This methods ensures that the SecondaryTile instance is initialized as expected.
		/// 
		///   In contrast to WP8 Tiles,  UWP Tiles require having a value for the following properties:
		///    - TileId
		///    - DisplayName
		///    - Arguments
		///    - VisualElements.Square150x150Logo
		/// 
		///  See https://msdn.microsoft.com/en-us/library/windows/apps/br242213.aspx for more details.
		/// </summary>
		/// <param name="tile"></param>
		/// <param name="tileUri"></param>
		/// <returns></returns>
		public static SecondaryTile FinishInitialization(this SecondaryTile tile, Uri tileUri)
		{
			var tileId = tileUri.AbsolutePath.Replace('/', '_');
			
			if (string.IsNullOrWhiteSpace(tile.TileId))
			{
				tile.TileId = tileId;
			}
			if (string.IsNullOrWhiteSpace(tile.DisplayName))
			{
				tile.DisplayName = "-NO DISPLAY NAME-";
			}else
			{
				tile.VisualElements.ShowNameOnSquare150x150Logo = true;
			}
			if (string.IsNullOrWhiteSpace(tile.Arguments))
			{
				var argsFromUri = (tileUri.Query ?? "").TrimStart('?');
				if (string.IsNullOrEmpty(argsFromUri))
				{
					tile.Arguments = "arg=defaultArg";
				}
				else
				{
					tile.Arguments = argsFromUri;
				}
			}

			if (tile.VisualElements.Square150x150Logo.AbsolutePath == "/")
			{
				tile.VisualElements.Square150x150Logo = new Uri("ms-appx:///Assets/Square150x150Logo.scale-200.png");
			}

			return tile;
		}




		public static Uri GetAsNavigationUri(this SecondaryTile tile)
		{
			return new Uri(tile.TileId.Replace('_', '/') + "?" + tile.Arguments, UriKind.Relative);
		}
	}
}
