using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static bool ConvertInputToNumeric(string argTextInput, out double result)
        {

            bool success = double.TryParse(argTextInput, out double localResult);

            result = localResult;
            return success;

        }

    }
}
