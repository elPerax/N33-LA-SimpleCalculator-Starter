using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static bool ConvertInputToNumeric(string argTextInput, out int result)
        {

            bool success = int.TryParse(argTextInput, out int localResult);

            result = localResult;
            return success;

        }

    }
}
