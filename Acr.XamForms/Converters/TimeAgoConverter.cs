using System;
using System.Globalization;
using Humanizer;
using Xamarin.Forms;


namespace Acr.XamForms.Converters {

    public class TimeAgoConverter : IValueConverter {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            DateTime dt;
            var dto = value as DateTimeOffset?;

            if (dto != null)
                dt = dto.Value.UtcDateTime;
            else {
                var date = value as DateTime?;
                if (date == null)
                    throw new ArgumentException("Value is not a DateTime or DateTimeOffset");

                dt = date.Value;
            }
            return dt.Humanize(culture: culture);
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException("TimeAgo is a one-way converter");
        }
    }
}
