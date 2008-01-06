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

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches <= (value - 584))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
