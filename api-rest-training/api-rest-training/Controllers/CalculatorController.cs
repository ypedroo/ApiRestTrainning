using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_rest_training.Repositories.Interfaces;

namespace api_rest_training.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorRepository calc;
        public CalculatorController(ICalculatorRepository calc)
        {
            this.calc = calc;
        }
        // GET api/values/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            var number1 = calc.IsNumeric(firstNumber);
            var number2 = calc.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var sum = calc.ConvertToDecimal(firstNumber) + calc.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }
        //GET api/value/sub/5/5
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            var number1 = calc.IsNumeric(firstNumber);
            var number2 = calc.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var sub = calc.ConvertToDecimal(firstNumber) - calc.ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid input");
        }
        //GET api/value/mult/5/5
        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Mult(string firstNumber, string secondNumber)
        {
            var number1 = calc.IsNumeric(firstNumber);
            var number2 = calc.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var mult = calc.ConvertToDecimal(firstNumber) * calc.ConvertToDecimal(secondNumber);
                return Ok(mult.ToString());
            }
            return BadRequest("Invalid input");
        }
        //GET api/value/div/5/5
        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            var number1 = calc.IsNumeric(firstNumber);
            var number2 = calc.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var div = calc.ConvertToDecimal(firstNumber) / calc.ConvertToDecimal(secondNumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid input");
        }
        //GET api/value/mean/5/5
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            var number1 = calc.IsNumeric(firstNumber);
            var number2 = calc.IsNumeric(secondNumber);
            if (number1 && number2) 
            {
                var mean = (calc.ConvertToDecimal(firstNumber) + calc.ConvertToDecimal(secondNumber) )/ 2;
                return Ok(mean.ToString());
            }
            return BadRequest("Invalid Input");
        }
        //GET api/values/sqrt/5
        [HttpGet("sqrt/{firstNumber}")]
        public IActionResult Sqrt(string firstNumber)
        {
            var number = calc.IsNumeric(firstNumber);
            var numberFormat = calc.ConvertToDecimal(firstNumber);
            if (number)
            {
                var sqrt = Math.Sqrt(decimal.ToDouble(numberFormat));
                return Ok(sqrt.ToString());
            }
            return BadRequest("Invalid input");
        }


    }
}
