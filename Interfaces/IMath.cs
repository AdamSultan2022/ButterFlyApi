using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButterFlyApi.Interfaces
{
   public interface IMath
    {
        Task<double> AddAsync(double number1, double number2);
        Task<double> AddWithRoundAsync(double number1, double number2, int round);
        Task<double> SubtractionAsync(double number1, double number2);
        Task<double> SubtractionWithRoundAsync(double number1, double number2, int round);
        Task<double> MultiplicationAsync(double number1, double number2);
        Task<double> MultiplicationWithRoundAsync(double number1, double number2, int round);
        Task<double> DivisionAsync(double number1, double number2);
        Task<double> DivisionWithRoundAsync(double number1, double number2, int round);

    }
}
