using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ButterFlyApi.infrastructure;
using ButterFlyApi.Interfaces;

namespace ButterFlyApi.Controllers
{
    [Validator]
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        readonly IMath _math;
        public MathController(IMath math)
        {
            _math = math;
        }
        
        [HttpGet]
        [Route("addition/{input1}&{input2}")]
        public async Task<double> addition(double input1, double input2)
        {

            return await _math.AddAsync(input1, input2);

        }

        [HttpGet]
        [Route("additionwithround/{input1}&{input2}&{round}")]
        public async Task<double> additionWithRound(double input1, double input2, int round)
        {

            return await _math.AddWithRoundAsync(input1, input2, round);
            

        }

        [HttpGet]
        [Route("subtruction/{input1}&{input2}")]
        public async Task<double> subtruction(double input1, double input2)
        {

            return await _math.SubtractionAsync(input1, input2);

        }

        [HttpGet]
        [Route("subtructionwithround/{input1}&{input2}&{round}")]
        public async Task<double> subtructionWithRound(double input1, double input2, int round)
        {

            return await _math.SubtractionWithRoundAsync(input1, input2, round);
            

        }

        [HttpGet]
        [Route("division/{input1}&{input2}")]
        public async Task<double> Division(double input1, double input2)
        {

            return await _math.DivisionAsync(input1, input2);

        }

        [HttpGet]
        [Route("divisionwithround/{input1}&{input2}&{round}")]
        public async Task<double> DivisionWithRound(double input1, double input2, int round)
        {

            return await _math.DivisionWithRoundAsync(input1, input2, round);
           
        }
        [HttpGet]
        [Route("multiplication/{input1}&{input2}")]
        public async Task<double> Multiplication(double input1, double input2)
        {

            return await _math.MultiplicationAsync(input1, input2);

        }

        [HttpGet]
        [Route("multiplicationwithround/{input1}&{input2}&{round}")]
        public async Task<double> MultiplicationWithRound(double input1, double input2, int round)
        {

            return await _math.MultiplicationWithRoundAsync(input1, input2, round);

        }

    }
}
