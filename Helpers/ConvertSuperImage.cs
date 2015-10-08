using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Display;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace WindowsPhoneUWP.UpgradeHelpers
{
    public class ConvertSuperImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int _resolution = System.Convert.ToInt32(parameter);
            DisplayInformation display = DisplayInformation.GetForCurrentView();
            ResolutionScale scale = display.ResolutionScale;
            return (int)scale == _resolution ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }


    public class ResolutionRange {
        public int MinScale { get; set; }
        public int MaxScale { get; set; }
    }

    public class UtilityProperties
    {

        public static ResolutionRange GetSpecialVisibility(DependencyObject obj)
        {
            return (ResolutionRange)obj.GetValue(SpecialVisibilityProperty);
        }

        public static void SetSpecialVisibility(DependencyObject obj, ResolutionRange value)
        {

            
            DisplayInformation display = DisplayInformation.GetForCurrentView();
            ResolutionScale scale = display.ResolutionScale;
            ((Windows.UI.Xaml.Controls.Image)obj).Visibility =   (value.MinScale <= (int)scale && value.MaxScale >= (int)scale) ? Visibility.Visible : Visibility.Collapsed;

            obj.SetValue(SpecialVisibilityProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpecialVisibilityProperty =
            DependencyProperty.RegisterAttached("SpecialVisibility", typeof(ResolutionRange), typeof(Windows.UI.Xaml.Controls.Image), new PropertyMetadata(0));

    }
}
