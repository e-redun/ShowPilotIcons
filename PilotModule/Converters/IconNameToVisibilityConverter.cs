using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace PilotModule.Converters
{
    public class IconNameToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] == null || values[1] == null)
            {
                return null;
            }

            var key = values[0].ToString();
            
            var filterText = values[1].ToString();

            if (string.IsNullOrWhiteSpace(filterText))
            {
                return Visibility.Visible;
            }

            if (key.ToLower().Contains(filterText.ToLower()))
            {
                return Visibility.Visible;
            }

            return Visibility.Collapsed;
        }



        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}