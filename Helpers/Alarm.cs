using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace WindowsPhoneUWP.UpgradeHelpers
{    
    public sealed class Alarm
    {
        public string _name { get; set; } // this property set a tag property on ScheduledToastNotification. It's usefull for reference like name inside a group of Notifications .
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
		_title = value;
                XmlNodeList toastTExtElement = toastDOM.GetElementsByTagName("text");
                toastTExtElement[0].AppendChild(toastDOM.CreateTextNode(value));
                _content = value; 
            }
        }        
        
        private string _content;
        public string Content {
            get { return _content; }
            set
            {
                XmlNodeList toastTExtElement = toastDOM.GetElementsByTagName("text");
                toastTExtElement[1].AppendChild(toastDOM.CreateTextNode(value));
                _content = value;
            }
        }
        public DateTime BeginTime { get; set; }
        public string Name { get; set; }
        private Uri _sound;
        public Uri Sound {
            get { return _sound; }
            set
            {
                IXmlNode toastNode = toastDOM.GetElementsByTagName("audio").First();
                ((XmlElement)toastNode).SetAttribute("src", value.ToString());
                _sound = value;
            }
        }


        private Windows.Data.Xml.Dom.XmlDocument toastDOM  { get; set; }

        public Alarm(string Name)
        {
            string toastXmlString = "<toast>"
                              + "<audio />"
                              + "<commands scenario='alarm'>"
                              + "<command id='snooze' />"
                              + "<command id='dismiss' />"
                              + "</commands>"
                              + "<visual version='1'>"
                              + "<binding template='ToastText02'>"
                              + "<text id='1'></text>"
                               + "<text id='2'></text>"
                              + "</binding>"
                              + "</visual>"
                              + "</toast>";
            toastDOM = new Windows.Data.Xml.Dom.XmlDocument();
            toastDOM.LoadXml(toastXmlString);           
        }

        public Windows.UI.Notifications.ScheduledToastNotification GetAlarm()
        {
            Windows.UI.Notifications.ScheduledToastNotification toast = new Windows.UI.Notifications.ScheduledToastNotification(toastDOM, BeginTime);
            toast.Tag = _name;
            return toast;
        }

	static public implicit operator Windows.UI.Notifications.ScheduledToastNotification(Alarm alarm)
        {
            return (alarm.GetAlarm());
        }
        
    }
}