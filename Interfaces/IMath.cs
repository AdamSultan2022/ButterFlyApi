using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButterFlyApi.Interfaces
{
   public interface IMath
    {
        Task<double> Add(double number1, double number2);
        Task<double> AddWithRound(double number1, double number2, int round);
        Task<double> Subtraction(double number1, double number2);
        Task<double> SubtractionWithRound(double number1, double number2, int round);
        Task<double> Multiplication(double number1, double number2);
        Task<double> MultiplicationWithRound(double number1, double number2, int round);
        Task<double> Division(double number1, double number2);
        Task<double> DivisionWithRound(double number1, double number2, int round);

    }
}
