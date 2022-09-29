using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ButterFlyApi.Interfaces;

namespace ButterFlyApi.infrastructure
{
    public class MathRepository : IMath
    {
        public async Task<double> AddAsync(double number1, double number2)
        {

            return await Task.FromResult<double>(number1 + number2); 
        }

        public async Task<double> AddWithRoundAsync(double number1, double number2, int round)
        {
          return await Task.FromResult<double>(Math.Round((number1 + number2), round));

        }

        public async Task<double> DivisionAsync(double number1, double number2)
        {
            return await Task.FromResult<double>(number1 / number2);
        }

        public async Task<double> DivisionWithRoundAsync(double number1, double number2, int round)
        {
            return await Task.FromResult<double>(Math.Round((number1 / number2), round));
        }

        public async Task<double> MultiplicationAsync(double number1, double number2)
        {
            return await Task.FromResult<double>(number1 * number2);
        }

        public async Task<double> MultiplicationWithRoundAsync(double number1, double number2, int round)
        {
            return await Task.FromResult<double>(Math.Round((number1 * number2), round));
        }

        public async Task<double> SubtractionAsync(double number1, double number2)
        {
            return await Task.FromResult<double>(number1 - number2);
        }

        public async Task<double> SubtractionWithRoundAsync(double number1, double number2, int round)
        {
            return await Task.FromResult<double>(Math.Round((number1 - number2), round));
        }
    }
}
