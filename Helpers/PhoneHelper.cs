using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace WindowsPhoneUWP.UpgradeHelpers
{
    public static class PhoneHelper
    {
        public static string getInfo(string ValueName)
        {
            var document = XDocument.Load("AppxManifest.xml");
            IEnumerable<XElement> name = from p in document.Descendants() where p.Attribute(ValueName) != null || p.Name.LocalName == ValueName select p;
            foreach (XElement item in name)
            {
                if (item.HasAttributes)
                {
                    string atribute = item.Attribute(ValueName).ToString();
                    return atribute;
                }
                else
                {
                    string content = item.Value;
                    return content;
                }
            }
            return "";
        }
    }
}
