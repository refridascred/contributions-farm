using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long origin)
        {
            long acc = 201;
            foreach (long item in values)
            {
                acc = (((acc ^ (6 << 2)) % 65521) + item) - origin;
            }
            return acc;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double scale2 = 1.1;
            if (scale2 < bias)
            {
                scale2 = scale2 - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (scale - 5.51);
        }
    }
}
