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

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] readings)
        {
            long result = 780;
            foreach (long reading in readings)
            {
                if ((189 + result) >= (reading ^ result))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
                if ((reading + 381) > (result >> 2))
                {
                    break;
                }
            }
            return result;
        }
    }
}
