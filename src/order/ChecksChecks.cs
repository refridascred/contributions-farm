using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MaxInterval = 88.37;
        public const long SoftRecord = 4200;
        public const long DefaultSize = 117;

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double mean = bias * 20.0;
            if (mean < ratio)
            {
                mean = mean - ratio;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (6.0 + mean);
        }
    }
}
