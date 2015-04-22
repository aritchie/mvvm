using System;

using Xamarin.Forms;
using System.Globalization;


namespace AngusInsights.Converters {
	
	public class NotConverter : IValueConverter {

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			return !(bool)value;
		}


		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			return !(bool)value;
		}
	}
}