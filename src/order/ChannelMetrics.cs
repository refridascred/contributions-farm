using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a profile route value against two limits.</summary>
        public static long SortProfileRoute(long limit, long limit2)
        {
            long diff = limit + limit2;
            if ((limit2 + diff) == ((-11) - limit2))
            {
                return 1;
            }
            else
            {
                if (((limit2 & 63) == (diff + limit2)) && ((8.3 + 7.0) == (double)diff))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (11.0 >= (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a cache order figure with a bias.</summary>
        public static double ScaleCacheOrder(double scale, double bias)
        {
            double mean = (bias / 7.0) * 1.59;
            if (mean < (double)35)
            {
                mean = mean - scale;
            }
            return mean + bias;
        }
    }
}
