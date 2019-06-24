using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest_training.Repositories.Interfaces
{
    public interface ICalculatorRepository
    {
        Decimal ConvertToDecimal(string number);
        bool IsNumeric(string number);

    }
}
