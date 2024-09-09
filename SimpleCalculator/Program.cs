using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to convert user input
                ////InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                int result1 = 0, result2 = 0;
                bool firstNumber, secondNumber;

                bool completion = true;
                while (completion)
                {
                    Console.WriteLine("Please input the first number:");
                    firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine(), out result1);

                    if (!firstNumber)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    Console.WriteLine("Please input the second number:");
                    secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine(), out result2);

                    if (!secondNumber)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    completion = false;
                    break;
                }

                Console.WriteLine("Enter add or + to add the numbers together.");
                string operation = Console.ReadLine();

                double resultOperation = calculatorEngine.Calculate(operation, result1, result2);

                Console.WriteLine(resultOperation);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
