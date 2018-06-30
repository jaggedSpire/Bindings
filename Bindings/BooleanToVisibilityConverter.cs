using System;
using System.Globalization;
using System.Windows.Data;

namespace Bindings
{
    class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var boolean = value as bool?;
            if (!boolean.HasValue) { return null; }
            return boolean.Value ?
                System.Windows.Visibility.Visible :
                System.Windows.Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException($"{GetType().Name} supports only one-way bindings");
        }
    }
}
