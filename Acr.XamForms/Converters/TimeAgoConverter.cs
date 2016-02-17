//using System;
//using System.Globalization;
//using Humanizer;
//using Xamarin.Forms;


//namespace Acr.XamForms {

//    public class TimeAgoConverter : IValueConverter {

//        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
//            if (value == null)
//                return String.Empty;

//            DateTime dt;
//            var t = value.GetType();

//            if (t == typeof(DateTime))
//                dt = (DateTime)value;
//            else if (t == typeof(DateTimeOffset))
//                dt = ((DateTimeOffset)value).UtcDateTime;
//            else if (t == typeof(DateTime?))
//                dt = ((DateTime?)value).Value;
//            else if (t == typeof(DateTimeOffset?))
//                dt = ((DateTimeOffset?)value).Value.UtcDateTime;
//            else
//                throw new ArgumentException("Value is not a DateTime or DateTimeOffset");

//            return dt.Humanize(culture: culture);
//        }


//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
//            throw new NotSupportedException("TimeAgo is a one-way converter");
//        }
//    }
//}
