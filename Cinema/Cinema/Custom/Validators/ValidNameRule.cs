﻿using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Cinema.validators
{
    public class ValidNameRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string name = value as string;

            if (name == null || name == "")
            {
                return new ValidationResult(false, "Can't be left empty!");
            }
            else
            {
                if (Regex.IsMatch(name, @"^[a-zA-ZąćęłśźżóńĄĆĘŁŚŹŻÓŃ ]+$"))
                {
                    return new ValidationResult(true, null);
                }
                else
                {
                    return new ValidationResult(false, "Illegal characters!");
                }
            }
        }
    }
}
