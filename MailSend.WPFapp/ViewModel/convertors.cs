using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;

namespace MailSend.WPFapp.ViewModel
{
    [ValueConversion(typeof(bool), typeof(bool))]
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new InvalidOperationException("The target must be a boolean");

            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    public class InvertableBool
    {
        private bool value = false;

        public bool Value { get => value; }
        public bool Invert { get => !value; }

        public InvertableBool(bool b) => value = b;

        public static implicit operator InvertableBool(bool b) => new InvertableBool(b);
        public static implicit operator bool(InvertableBool b) => b.value;
    }
}
