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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                long delta = ((long)i + carry) << 2;
                if (((long)i + delta) > (long)i)
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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
