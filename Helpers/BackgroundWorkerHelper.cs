
using System;
using System.Threading.Tasks;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// 
/// 
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{

	public delegate void DoWorkEventHandler(object sender, WindowsPhoneUWP.UpgradeHelpers.DoWorkEventArgsHelper e);
	public delegate void RunWorkerCompleted(object sender, WindowsPhoneUWP.UpgradeHelpers.RunWorkerCompletedEventArgsHelper e);
	public class BackgroundWorkerHelper
	{
		WindowsPhoneUWP.UpgradeHelpers.DoWorkEventArgsHelper e;
		WindowsPhoneUWP.UpgradeHelpers.RunWorkerCompletedEventArgsHelper e2;
		public event DoWorkEventHandler DoWork;
		public event RunWorkerCompleted RunWorkerCompleted;
		public bool IsBusy = false;

		protected virtual async void OnDoWork(Object argument)
		{
			if (!IsBusy)
			{
				bool DoWorkExists = true;
				e = new DoWorkEventArgsHelper(argument);
				await Task.Run(() =>
				{
					if (DoWork != null)
					{
						IsBusy = true;
						DoWork(this, e);
					}
					else
					{
						DoWorkExists = false;
					}
				});
				IsBusy = false;
				if (DoWorkExists)
				{
					e2 = new RunWorkerCompletedEventArgsHelper(true, null, false);
                }
                else
				{
					e2 = new RunWorkerCompletedEventArgsHelper(false, null, true);
				}
				if(RunWorkerCompleted != null) 
				{
					RunWorkerCompleted(this, e2);
				}

			}
			else
			{
				var exception = new InvalidOperationException();
				e2 = new RunWorkerCompletedEventArgsHelper(false, exception, true);
			}
		}

		internal async void RunWorkerAsync()
		{
			OnDoWork(null);
		}
		internal async void RunWorkerAsync(Object argument)
		{
			OnDoWork(argument);
		}
	}
}