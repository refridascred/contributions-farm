using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double span)
        {
            double scale = weight * 8.87;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale - scale)) - (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Count the cache support entries that pass the check.</summary>
        public static long TallyCacheSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)297 < (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
