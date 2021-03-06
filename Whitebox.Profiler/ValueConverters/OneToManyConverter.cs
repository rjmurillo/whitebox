﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Whitebox.Profiler.ValueConverters
{
    class OneToManyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return new[] {value};
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
