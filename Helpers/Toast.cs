using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPhoneUWP.UpgradeHelpers
{
    class ToastPrompt : Windows.UI.Notifications.ToastNotificationManager
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public Windows.UI.Xaml.Media.Imaging.BitmapImage imageSource { get; set; }    
        public int MillisecondsUntilHidden { get; set; }
        public Windows.UI.Notifications.ToastNotification toast;

        public ToastPrompt()
        {

        }

        
        public void Show()
        {
            Windows.UI.Notifications.ToastTemplateType toastTemplate;
            Windows.Data.Xml.Dom.XmlDocument toastDOM;
            if (imageSource != null) //ToastImage....
            {
                toastTemplate = Windows.UI.Notifications.ToastTemplateType.ToastImageAndText02;
                toastDOM = Windows.UI.Notifications.ToastNotificationManager.GetTemplateContent(toastTemplate);
                Windows.Data.Xml.Dom.XmlNodeList ToastImageElements = toastDOM.GetElementsByTagName("image");
                ((Windows.Data.Xml.Dom.XmlElement)ToastImageElements[0]).SetAttribute("src", imageSource.ToString());

            }
            else
            {
                toastTemplate = Windows.UI.Notifications.ToastTemplateType.ToastText02;
                toastDOM = Windows.UI.Notifications.ToastNotificationManager.GetTemplateContent(toastTemplate);
            }
            var toastTextElements = toastDOM.GetElementsByTagName("text");
            ((Windows.Data.Xml.Dom.XmlElement)toastTextElements[0]).AppendChild(toastDOM.CreateTextNode(this.Title));
            ((Windows.Data.Xml.Dom.XmlElement)toastTextElements[1]).AppendChild(toastDOM.CreateTextNode(this.Message));

           

            Windows.Data.Xml.Dom.IXmlNode toastNode = toastDOM.SelectSingleNode("toast");

            if(MillisecondsUntilHidden > 30000)
            {
                ((Windows.Data.Xml.Dom.XmlElement)toastNode).SetAttribute("duration", "long");
            }
            else
            {
                ((Windows.Data.Xml.Dom.XmlElement)toastNode).SetAttribute("duration", "short");
            }

            toast = new Windows.UI.Notifications.ToastNotification(toastDOM);
            Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier().Show(toast);

        }

    }
}
