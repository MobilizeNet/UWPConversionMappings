using System;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{

	/// <summary>
	///  
	/// </summary>
	public static class WriteableBitmapHelper
	{
		public static async Task RenderHelper(WriteableBitmap targetBitmap, FrameworkElement control, Transform transform)
		{
			int x = 0, y = 0;
			if (transform is TranslateTransform)
			{
				await RenderHelper(
						targetBitmap,
						control,
						(int)((TranslateTransform)transform).X,
						(int)((TranslateTransform)transform).Y);
			}
			else
			{
				await RenderHelper(targetBitmap, control, 0, 0);
			}


		}
		public static async Task RenderHelper(WriteableBitmap targetBitmap, FrameworkElement control, int x, int y)
		{
			RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap();
			const int PixelSize = 4;

			Frame topFrame;
			Page topPage;
			Panel topPanel;
			if (((topFrame = Window.Current.Content as Frame).Content != null)
				&& ((topPage = topFrame.Content as Page) != null)
				&& ((topPanel = topPage.Content as Panel) != null))
			{
				/// Create a temporary container for the control to be rendered
				var tmpPanel = new StackPanel()
				{
					// We will try to render the control offscreen to avoid flickering
					RenderTransform = new TranslateTransform()
					{
						X = 1000,
						Y = 1000
					}
				};
				var oldParent = control.Parent;
				try
				{
					tmpPanel.Children.Add(control);
					topPanel.Children.Add(tmpPanel);
					await renderTargetBitmap.RenderAsync(control);
				}
				finally
				{
					tmpPanel.Children.Remove(control);
					topPanel.Children.Remove(tmpPanel);
				}

				var array = (await renderTargetBitmap.GetPixelsAsync()).ToArray();

				using (var targetStream = targetBitmap.PixelBuffer.AsStream())
				{
					var startOfLine = y * targetBitmap.PixelWidth * PixelSize;
					for (int i = 0; i < renderTargetBitmap.PixelHeight
									&& i < targetBitmap.PixelHeight
									&& startOfLine < targetBitmap.PixelBuffer.Capacity; i++)
					{
						targetStream.Seek(startOfLine + (PixelSize * x), SeekOrigin.Begin);
						startOfLine = startOfLine + targetBitmap.PixelWidth * PixelSize;

						if (i * renderTargetBitmap.PixelWidth * PixelSize < targetBitmap.PixelBuffer.Capacity)
						{
							await targetStream.WriteAsync(array, i * renderTargetBitmap.PixelWidth * PixelSize, (int)Math.Min(Math.Min(renderTargetBitmap.PixelWidth, targetBitmap.PixelWidth - x) * PixelSize, (long)targetBitmap.PixelBuffer.Capacity));
						}
						else
						{
							break;
						}
					}
				}
			}
		}
	}
}
