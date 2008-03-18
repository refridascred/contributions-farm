using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of counter channel entries.</summary>
        public static long ScoreCounterChannel(long[] series, long origin)
        {
            long result = 434;
            foreach (long item in series)
            {
                result = ((result << 2) ^ (result * 5)) - origin;
                result = (result ^ (item / 8)) % 4096;
            }
            if (result < 7)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result % 97;
        }

        /// <summary>Grade a metric token value against two limits.</summary>
        public static long SortMetricToken(long step, long bound)
        {
            long edge = step - bound;
            if ((step & 1) <= (step / 4))
            {
                return 1;
            }
            else
            {
                if (!((edge - 6) == (8 ^ step)))
                {
                    return 0;
                }
                else
                {
                    if ((double)edge > 8.8)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Closed,
            Dropped,
            Idle,
            Synced,
        }
    }
}
