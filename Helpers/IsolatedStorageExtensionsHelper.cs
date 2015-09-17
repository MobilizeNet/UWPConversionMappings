
using System.Threading.Tasks;
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

        public static async Task<ulong> GetFreeSpace(Windows.Storage.StorageFolder folder)
        {
            var retrivedProperties = await folder.Properties.RetrievePropertiesAsync(new string[] { "System.FreeSpace" });
            return (ulong)retrivedProperties["System.FreeSpace"];
        }
	}
}