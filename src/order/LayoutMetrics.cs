using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "standard-edge";
        public const long BaseMetrics = 9744;
        public const long HardMetrics = 9609;
        public const long WindowMetrics = 194;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next format counter value.</summary>
        public static double ProjectFormatCounter(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 >= bias)
            {
                bias3 = bias3 - (bias / 5.0);
            }
            return bias3 - (bias2 * 10.0);
        }
    }
}
