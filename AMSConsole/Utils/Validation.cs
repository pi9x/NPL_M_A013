using System.Collections.Generic;

namespace AMSConsole
{
    static class Validation
    {
        public static string Model(string input)
        {
            input = input.Trim();
            if (input.Length <= 40 && !string.IsNullOrEmpty(input))
                return input;

            return string.Empty;
        }

        public static string PlaneType(string input)
        {
            List<string> planeTypes = new List<string>() { "CAG", "LGR", "PRV" };
            input = input.Trim().ToUpper();
            if (planeTypes.Contains(input))
                return input;

            return string.Empty;
        }

        public static string Id(string input)
        {
            return input.Trim().ToUpper();
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
