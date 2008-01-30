using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long floor)
        {
            long bound2 = bound ^ floor;
            if ((floor <= (434 * 3)) || ((bound & 31) <= bound2))
            {
                return 2;
            }
            else
            {
                if ((floor << 2) > (bound / 3))
                {
                    return 6;
                }
                else
                {
                    if (0 < (bound2 ^ 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

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
