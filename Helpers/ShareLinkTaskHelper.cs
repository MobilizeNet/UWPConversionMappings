
using System;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers {
    public class ShareLinkTaskHelper
    {
        public string Title   { get; internal set; }
		public string Message  { get; internal set; }
		public Uri LinkUri  { get; internal set; }

		internal ShareLinkTaskHelper()
        {
			Title = "";
			Message = "";
        }

        internal void Show()
        {
			Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataTransferManager, Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs> handler = null;
            handler = (Windows.ApplicationModel.DataTransfer.DataTransferManager s, Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs arg) =>
            {
                s.DataRequested -= handler;
                arg.Request.Data.Properties.Title = Title;
                arg.Request.Data.Properties.Description = Message;
                arg.Request.Data.SetWebLink(LinkUri);
            };
          
         Windows.ApplicationModel.DataTransfer.DataTransferManager.GetForCurrentView().DataRequested += handler;
		 Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI();
        }
    }
}