using System;
using Windows.UI.Xaml.Controls;

namespace WindowsPhoneUWP.UpgradeHelpers
{

    public class MessagePrompt : ContentDialog
    {
        MessagePomptUserControl MyControl;

        public MessagePrompt()
        {
            MyControl = new MessagePomptUserControl();
            PrimaryButtonText = "\u2713";
            MyControl.DataContext = this;
            this.ActionPopUpButtons = new System.Collections.ObjectModel.ObservableCollection<Windows.UI.Xaml.Controls.Button>();
            this.ActionPopUpButtons.CollectionChanged += ActionPopUpButtons_CollectionChanged;
        }

        internal void ActionPopUpButtons_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            MyControl.setButton(this.ActionPopUpButtons);
        }

        public System.Collections.ObjectModel.ObservableCollection<Windows.UI.Xaml.Controls.Button> ActionPopUpButtons;       

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

        public object _Content;
        public object Message
        {
            get
            {
                return _Content;
            }
            set
            {
                _Content = value;
                this.Content = value;
              
            }

        }

  
        async public void Show()
        {
            this.Content = MyControl;
           
            await this.ShowAsync();
        }         
    }
}
