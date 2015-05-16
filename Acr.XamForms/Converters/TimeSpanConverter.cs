using System;
using System.Globalization;
using Humanizer;
using Humanizer.Localisation;
using Xamarin.Forms;


namespace Acr.XamForms {

    public class TimeSpanConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value == null)
                return String.Empty;

            TimeSpan ts;
            var t = value.GetType();
            if (t == typeof(TimeSpan))
                ts = (TimeSpan)value;
            else if (t == typeof(TimeSpan?))
                ts = ((TimeSpan?)value).Value;
            else
                throw new ArgumentException("Value is not a timespan");

            return ts.Humanize(culture: culture, maxUnit: TimeUnit.Week);
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
