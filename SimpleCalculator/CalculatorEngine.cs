using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            switch (argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = (argFirstNumber + argSecondNumber);
                    break;

                case "substract":
                case "-":
                    result = (argFirstNumber - argSecondNumber);
                    break;

                case "multiply":
                case "*":
                    result = (argFirstNumber * argSecondNumber);
                    break;

                case "divide":
                case "/":
                    if (argSecondNumber != 0)
                    {
                        result = (argFirstNumber / argSecondNumber);
                    }
                    else
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                    break;
                case "raised":
                case "^":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;

            }




            return result;
        }
    }
}
