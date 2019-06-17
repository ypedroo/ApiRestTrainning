using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest_training.Services.Interfaces
{
    public interface IDye
    {
        Decimal ConvertToDecimal(string number);
        bool IsNumeric(string number);

    }
}
