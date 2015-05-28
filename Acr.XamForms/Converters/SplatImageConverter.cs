//using System;
//using System.Globalization;
//using System.Threading;
//using Splat;
//using Xamarin.Forms;


//namespace Acr.XamForms {

//    public class SplatImageConverter : IValueConverter {

//        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
//            var bitmap = value as IBitmap;
//            if (bitmap == null)
//                throw new ArgumentException("");

//            return ImageSource.FromStream(() => bitmap);
//        }


//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
//            var file = value as FileImageSource;
//            if (file != null)
//                return BitmapLoader.Current.Load(file.File);

//            var res = value as StreamImageSource;
//            if (res != null) {
//                var stream = res.Stream(CancellationToken.None).Result;
//                return BitmapLoader.Current.Load(stream).Result;
//            }

//            return null;
//        }
//    }
//}
