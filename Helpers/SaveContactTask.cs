using System;
using System.Collections.Generic;
using Windows.Phone.PersonalInformation;

namespace WindowsPhoneUWP.UpgradeHelpers
{
    public static class SaveContactTask
    {
        public static async void Save(string givenName, string familyName, string mobile)
        {
            ContactStore store = await ContactStore.CreateOrOpenAsync();

            StoredContact contact = new StoredContact(store);
            contact.GivenName = givenName;
            contact.FamilyName = familyName;

            IDictionary<string, object> props = await contact.GetPropertiesAsync();
            props.Add(KnownContactProperties.MobileTelephone, mobile);

            await contact.SaveAsync();
        }
    }
}