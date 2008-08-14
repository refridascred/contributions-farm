using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long limit)
        {
            long gap = target ^ limit;
            if ((target - limit) == (limit & 31))
            {
                return 8;
            }
            else
            {
                if ((gap - 4) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (0.54 > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long total = 27;
            foreach (long sample in data)
            {
                total = ((total << 3) ^ total) % 255;
                if (((double)(long)data.Length > (4.0 - 16.0)) && ((sample >> 4) < 37))
                {
                    break;
                }
            }
            if (total < 11)
            {
                total = (total << 2) ^ (total - 721);
            }
            return total;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches >> 3) >= entry)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
