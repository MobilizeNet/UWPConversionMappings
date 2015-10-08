using System;
using Windows.UI.Xaml.Controls;

namespace WindowsPhoneUWP.UpgradeHelpers
{

    public class AboutPromptItem
    {
        public string AuthorName { get; set; }
        public string EmailAddress { get; set; }
        public string Role { get; set; }
        protected internal string WebSiteDisplay { get; set; }
        public string WebSiteUrl { get; set; }
    }


    public class AboutPrompt : ContentDialog
    {
        AboutPromptUserControl MyControl;

        public AboutPrompt()
        {
            MyControl = new AboutPromptUserControl();
            MyControl.DataContext = this;
        }

        public object _body;
        public object Body
        {
            get
            { return _body; }
            set
            {
                _body = value;
                MyControl.setBody(value);
            }
        }

        public object _footer;
        public object Footer
        {
            get
            {
                return _footer;
            }
            set
            {
                _footer = value;
                MyControl.setFooter(value);
            }

        }

        // HAY QUE VERIFICAR SI ESTE SE PUEDE MAPEAR        public bool IsPromptMode { get; set; }

        public string _title;
        public new string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                MyControl.setTitle(value);
            }
        }

        public string _versionNumber;

        public string VersionNumber
        {
            get
            {
                return _versionNumber;
            }
            set
            {
                _versionNumber = value;
                MyControl.setVersionNumber(value);
            }
        }

        public object _waterMark;
        public object WaterMark
        {
            get
            {
                return _waterMark;
            }
            set
            {
                _waterMark = value;
                MyControl.setWaterMark(value);
            }
        }

        //public override void OnApplyTemplate();
        async public void Show()
        {
            this.Content = MyControl;
            this.PrimaryButtonText = "Ok";
            await this.ShowAsync();
        }

        async public void Show(AboutPromptItem item)
        {
            MyControl.setAuthorName(item.AuthorName);
            MyControl.setEmailAddress(item.EmailAddress);
            MyControl.setRole(item.Role);
            MyControl.setWebSiteUrl(item.WebSiteUrl);

            this.Content = MyControl;
            this.PrimaryButtonText = "Ok";
            await this.ShowAsync();
        }
        //public void Show(string authorName, string twitterName = null, string emailAddress = null, string websiteUrl = null);
    }
}
