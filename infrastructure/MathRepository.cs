using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ButterFlyApi.Interfaces;

namespace ButterFlyApi.infrastructure
{
    public class MathRepository : IMath
    {
        public async Task<double> Add(double number1, double number2)
        {

            return await Task.FromResult<double>(number1 + number2); 
        }

        public async Task<double> AddWithRound(double number1, double number2, int round)
        {
          return await Task.FromResult<double>(Math.Round((number1 + number2), round));

        }

        public async Task<double> Dividing(double number1, double number2)
        {
            return await Task.FromResult<double>(number1 / number2);
        }

        public async Task<double> DividingWithRound(double number1, double number2, int round)
        {
            return await Task.FromResult<double>(Math.Round((number1 / number2), round));
        }

        public async Task<double> Multiplication(double number1, double number2)
        {
            return await Task.FromResult<double>(number1 * number2);
        }

        public async Task<double> MultiplicationWithRound(double number1, double number2, int round)
        {
            return await Task.FromResult<double>(Math.Round((number1 * number2), round));
        }

        public async Task<double> Subtraction(double number1, double number2)
        {
            return await Task.FromResult<double>(number1 - number2);
        }

        public async Task<double> SubtractionWithRound(double number1, double number2, int round)
        {
            return await Task.FromResult<double>(Math.Round((number1 - number2), round));
        }
    }
}
