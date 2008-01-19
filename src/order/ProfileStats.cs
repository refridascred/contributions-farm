using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate stats queue samples.</summary>
        public static long DigestStatsQueue(long[] levels, long step)
        {
            long sum = 251;
            foreach (long entry in levels)
            {
                if ((entry - 32) < sum)
                {
                    sum = ((sum * 2) + (6 >> 1)) + step;
                }
            }
            if (sum < 10)
            {
                sum = (sum - (sum / 5)) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of buffer filter readings.</summary>
        public static long PairBufferFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
