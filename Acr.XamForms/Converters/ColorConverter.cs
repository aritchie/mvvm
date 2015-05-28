//using System;
//using System.Globalization;
//using C = System.Drawing.Color;
//using Xamarin.Forms;


//namespace Acr.XamForms {

//    public class ColorConverter : IValueConverter {

//        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
//            var color = (C)value;
//            return Color.FromRgba(color.R, color.G, color.B, color.A);
//        }


//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
//            var color = (Color)value;
//            return C.FromArgb((int)color.A, (int)color.R, (int)color.G, (int)color.B);
//        }
//    }
//}
