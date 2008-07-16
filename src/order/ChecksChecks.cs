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

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long target)
        {
            long sum = -7;
            foreach (long entry in values)
            {
                if (target <= (target + 683))
                {
                    sum = sum + (65 ^ entry);
                }
                if (entry >= (sum + entry))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
