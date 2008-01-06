using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell * 3) < (tally - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank channel token input into a small class.</summary>
        public static long ClassifyChannelToken(long seed, long limit)
        {
            long offset = seed ^ limit;
            if ((6.76 / 4.0) > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset <= (limit >> 1)) && ((limit % 10) != (39 % 10)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
