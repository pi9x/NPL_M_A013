using System;
using System.Collections.Generic;
using System.Text;

namespace AMSConsole
{
    public static class Validation
    {


        public static string Model(string input)
        {
            input = input.Trim();
            if (input.Length <= 40 && !string.IsNullOrEmpty(input))
                return input;

            return string.Empty;
        }

        public static double PositiveDouble(string input)
        {
            _ = double.TryParse(input.Trim(), out double result);
            if (result > 0)
                return result;

            return 0;
        }

        public static int PositiveInteger(string input)
        {
            _ = int.TryParse(input.Trim(), out int result);
            if (result > 0)
                return result;

            return 0;
        }
    }
}
