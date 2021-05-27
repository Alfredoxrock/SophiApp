﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SophiApp.Converters
{
    internal class IntToVisibilityCollapsed : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var count = System.Convert.ToUInt32(value);
            return count > 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}