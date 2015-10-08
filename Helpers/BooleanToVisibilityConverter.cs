using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace WindowsPhoneUWP.UpgradeHelpers
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var boolValue = System.Convert.ToBoolean(value);
            if(parameter != null)
            {
                boolValue = !boolValue;
            }
            return boolValue ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value.Equals(Visibility.Visible);
        }
    }
}
