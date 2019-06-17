﻿using System;
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
        private readonly IDye Dye;
        public CalculatorController(IDye Dye)
        {
            this.Dye = Dye;
        }
        // GET api/values/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            var number1 = Dye.IsNumeric(firstNumber);
            var number2 = Dye.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var sum = Dye.ConvertToDecimal(firstNumber) + Dye.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }
        //GET api/value/sub/5/5
        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            var number1 = Dye.IsNumeric(firstNumber);
            var number2 = Dye.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var sub = Dye.ConvertToDecimal(firstNumber) - Dye.ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid input");
        }
        //GET api/value/mult/5/5
        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Mult(string firstNumber, string secondNumber)
        {
            var number1 = Dye.IsNumeric(firstNumber);
            var number2 = Dye.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var sub = Dye.ConvertToDecimal(firstNumber) * Dye.ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid input");
        }
        //GET api/value/div/5/5
        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            var number1 = Dye.IsNumeric(firstNumber);
            var number2 = Dye.IsNumeric(secondNumber);
            if (number1 && number2)
            {
                var sub = Dye.ConvertToDecimal(firstNumber) / Dye.ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid input");
        }


    }
}
