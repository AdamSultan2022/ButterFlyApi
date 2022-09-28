using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ButterFlyApi.infrastructure;
using ButterFlyApi.Interfaces;

namespace ButterFlyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        readonly IMath _math;
        public MathController(IMath math)
        {
            _math = math;
        }
        [Validator]
        [HttpGet]
        [Route("addition/{input1}&{input2}")]
        public async Task<double> addition(double input1, double input2)
        {

            return await _math.Add(input1, input2);

        }
        [HttpGet]
        [Route("additionwithround/{input1}&{input2}&{round}")]
        [Validator]
        public async Task<double> additionWithRound(double input1, double input2, int round)
        {

            return await _math.AddWithRound(input1, input2, round);
            

        }
        [HttpGet]
        [Route("subtruction/{input1}&{input2}")]
        [Validator]
        public async Task<double> subtruction(double input1, double input2)
        {

            return await _math.Subtraction(input1, input2);

        }
        [HttpGet]
        [Route("subtructionwithround/{input1}&{input2}&{round}")]
        [Validator]
        public async Task<double> subtructionWithRound(double input1, double input2, int round)
        {

            return await _math.SubtractionWithRound(input1, input2, round);
            

        }
        [HttpGet]
        [Route("dividing/{input1}&{input2}")]
        [Validator]
        public async Task<double> Dividing(double input1, double input2)
        {

            return await _math.Dividing(input1, input2);

        }
        [HttpGet]
        [Route("dividingwithround/{input1}&{input2}&{round}")]
        [Validator]
        public async Task<double> DividingWithRound(double input1, double input2, int round)
        {

            return await _math.DividingWithRound(input1, input2, round);
           

        }
        [HttpGet]
        [Route("multiplication/{input1}&{input2}")]
        [Validator]
        public async Task<double> Multiplication(double input1, double input2)
        {

            return await _math.Multiplication(input1, input2);

        }
        [HttpGet]
        [Route("multiplicationwithround/{input1}&{input2}&{round}")]
        [Validator]
        public async Task<double> MultiplicationWithRound(double input1, double input2, int round)
        {

            return await _math.MultiplicationWithRound(input1, input2, round);
            

        }

    }
}
