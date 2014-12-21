using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        public double firstNumber;
        public double secoundNumber;
        public double result;

        public double Add()
        {
            return firstNumber + secoundNumber;
        }

        public double Subtract()
        {
            return firstNumber - secoundNumber;
        }

        public double Multiply()
        {
            return firstNumber*secoundNumber;
        }

        public double Divide()
        {
            return firstNumber/secoundNumber;
        }
    }
}
