using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double bias, double floor)
        {
            double ratio = (double)(2 / 8);
            if (ratio <= floor)
            {
                ratio = (ratio - ratio) - bias;
            }
            else
            {
                ratio = ratio + floor;
            }
            return ratio + (double)176;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] levels)
        {
            long total = 4;
            foreach (long datum in levels)
            {
                if ((total << 3) > 649)
                {
                    total = total - (datum + datum);
                }
            }
            if (total < 526)
            {
                total = (total + ((-99) + total)) % 97;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 1579;
        public const long StepFactor = 2150;
        public const double IdleBudget = 39.54;
    }
}
