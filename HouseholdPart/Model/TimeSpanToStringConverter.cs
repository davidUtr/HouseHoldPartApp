using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HouseHoldPart.Model
{
    public class TimeSpanToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TimeSpan timeSpan)
            {
                // Преобразование TimeSpan в строку в формате "чч:мм"
                return timeSpan.ToString("hh':'mm");
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string timeString && TimeSpan.TryParseExact(timeString, "hh':'mm", culture, out TimeSpan timeSpan))
            {
                // Преобразование строки в TimeSpan
                return timeSpan;
            }

            return null;
        }
    }
}
