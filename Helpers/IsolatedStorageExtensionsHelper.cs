

using System;

namespace WindowsPhoneUWP.UpgradeHelpers
{

	static class IsolatedStorageExtensionsHelper
	{
		public static bool TryGetValue<T>(this Windows.Storage.ApplicationDataContainer settings, string key, out T value)
		{
			object tmp;
			bool result;
			value = default(T);
			if (result = settings.TryGetValue(key, out tmp))
			{
				value = (T)tmp;
			}
			return result;
		}
	}
}