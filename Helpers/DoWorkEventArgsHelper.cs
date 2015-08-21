
using System;

/// <summary>
/// ################################################################
///  EXPERIMENTAL HELPER IMPLEMENTATION
/// ################################################################
/// </summary>
namespace WindowsPhoneUWP.UpgradeHelpers
{

	public class DoWorkEventArgsHelper : EventArgs
	{
		public object Argument { get; }
		public bool Cancel { get; set; }
		public object Result { get; set; }

		public DoWorkEventArgsHelper(Object argument)
		{
			Argument = argument;
		}

	}
}