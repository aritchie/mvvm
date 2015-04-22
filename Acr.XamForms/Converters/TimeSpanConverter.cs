using System;
using System.Globalization;
using Humanizer;
using Humanizer.Localisation;
using Xamarin.Forms;


namespace Acr.XamForms.Converters {

    public class TimeSpanConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var ts = value as TimeSpan?;
            if (ts == null)
                throw new ArgumentException("Value is not a timespan");

            return ts.Value.Humanize(culture: culture, maxUnit: TimeUnit.Week);
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
