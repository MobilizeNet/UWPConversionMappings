using System;
using Windows.UI.Xaml.Controls;

namespace WindowsPhoneUWP.UpgradeHelpers
{

    public class InputPrompt : ContentDialog
    {
        InputPomptUserControl MyControl;

        public InputPrompt()
        {
            MyControl = new InputPomptUserControl();
            PrimaryButtonText = "\u2713";
            MyControl.DataContext = this;           
        }


        public Windows.UI.Xaml.Input.InputScope InputScope
        {
            get
            {
                return MyControl.getInputScope();
            }
            set
            {
                MyControl.setInputScope(value);
            }
        }

        public string Message
        {
            get
            {
                return MyControl.getMessage();
            }
            set
            {              
                MyControl.setMessage(value);
            }
        }

        public string Value
        {
            get
            {
                return MyControl.getValue();
            }
            set
            {                
                MyControl.setValue(value);
            }
        }
                    
       
        async public void Show()
        {
            this.Content = MyControl;       
            await this.ShowAsync();
        }
           
    }
}
