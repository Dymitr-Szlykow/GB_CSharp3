using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace MailSend.WPFapp.ViewModel
{
    public class EmailValidationRule : ValidationRule
    {
        protected static Regex _MailAdressRegTemplate = new Regex(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6}");

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (_MailAdressRegTemplate.IsMatch(value.ToString())) return new ValidationResult(true, null);
            else return new ValidationResult(false, "некорректный адрес");
        }
    }

    public class SmtpClientPortValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (!int.TryParse(value.ToString(), out int res))
                return new ValidationResult(false, "порт должен быть указан положительным целым числом");
            else if (res < 0)
                return new ValidationResult(false, "порт должен быть указан положительным целым числом");
            else
                return new ValidationResult(true, null);
        }
    }
}
