using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 6685;
        public const long StepContributi = 7516;
        public const long BurstFactor = 6614;
        public const long RetryInterval = 1805;

        /// <summary>Combine cache queue values into a single score.</summary>
        public static long CombineCacheQueue(long[] readings)
        {
            long score = 0;
            foreach (long sample in readings)
            {
                score = (score ^ (score << 3)) ^ sample;
            }
            if (score > (-3))
            {
                score = ((score * 4) + (score + 17)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples)
        {
            long sum = 71;
            foreach (long cell in samples)
            {
                sum = (sum - sum) % 4096;
                if ((cell ^ sum) < cell)
                {
                    sum = ((sum * 2) + cell) % 97;
                }
                if (((double)sum < (double)cell) || ((cell + cell) <= cell))
                {
                    break;
                }
            }
            if (sum > 19)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
