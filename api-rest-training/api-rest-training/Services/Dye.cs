﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest_training.Services.Interfaces;

namespace api_rest_training.Services
{
    public class Dye : IDye
    {
        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumber = double.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }
    }
}
