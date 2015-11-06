using System;
using System.Threading.Tasks;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace WindowsPhoneUWP.UpgradeHelpers
{
	/// <summary>
	/// ################################################################
	///  EXPERIMENTAL HELPER IMPLEMENTATION
	/// ################################################################
	/// </summary>
	public static class SpeachSynthHelpers
	{
		public static async Task SpeakSsmlHelperAsync(this SpeechSynthesizer synth, string ssmlText)
		{
			TaskCompletionSource<MediaElement> taskcompSource;
			MediaElement localMediaElement;
			GetTaskSourceAndMediaElement(out taskcompSource, out localMediaElement);
			var speechStream = await synth.SynthesizeSsmlToStreamAsync(ssmlText);
			localMediaElement.SetSource(speechStream, speechStream.ContentType);
			await taskcompSource.Task;
			speechStream.Dispose();
		}

		public static async Task SpeakTextHelperAsync(this SpeechSynthesizer synth, string text)
		{
			TaskCompletionSource<MediaElement> taskcompSource;
			MediaElement localMediaElement;
			GetTaskSourceAndMediaElement(out taskcompSource, out localMediaElement);
			var speechStream = await synth.SynthesizeTextToStreamAsync(text);
			localMediaElement.SetSource(speechStream, speechStream.ContentType);
			localMediaElement.Play();
			await taskcompSource.Task;
			speechStream.Dispose();
		}

		private static void GetTaskSourceAndMediaElement(out TaskCompletionSource<MediaElement> taskcompSource, out MediaElement localMediaElement)
		{
			taskcompSource = new TaskCompletionSource<MediaElement>();
			localMediaElement = new MediaElement() { AutoPlay = true, Visibility = Visibility.Collapsed };

			// We need to add the 'MediaElement' element to the screen 
			// if we don't add it to the screen the 'CurrentStateChanged' event is not raised
			Frame topFrame;
			Page topPage;
			Panel topPanel = null;
			if (((topFrame = Window.Current.Content as Frame).Content != null)
				&& ((topPage = topFrame.Content as Page) != null)
				&& ((topPanel = topPage.Content as Panel) != null))
			{
				topPanel.Children.Add(localMediaElement);
			}

			var tmpTaskcompSource = taskcompSource;
			var mediaElement = localMediaElement;
			RoutedEventHandler handler = null;
			handler = (sender, eventArgs) =>
			{
				if (mediaElement.CurrentState == MediaElementState.Buffering ||
					mediaElement.CurrentState == MediaElementState.Opening ||
					mediaElement.CurrentState == MediaElementState.Playing)
				{
					return;
				}

				mediaElement.CurrentStateChanged -= handler;
				tmpTaskcompSource.SetResult((MediaElement)mediaElement);
				if (topPanel != null)
				{
					topPanel.Children.Remove(mediaElement);
				}
			};
			localMediaElement.CurrentStateChanged += handler;
		}
	}
}
