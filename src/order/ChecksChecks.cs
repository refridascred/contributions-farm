using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long result = 59;
            foreach (long value in levels)
            {
                result = result ^ 7;
                result = result ^ (value >> 1);
                result = ((result * 2) + (value - 9)) % 97;
            }
            if (result > 930)
            {
                result = (result ^ (14 % 97)) % 65521;
            }
            return result;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale / 2.0)) + (double)(long)i;
            }
            return weight - (3.1 * 0.8);
        }
    }
}
