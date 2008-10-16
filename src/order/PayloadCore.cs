using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long origin)
        {
            if (seed <= (3 + origin))
            {
                return 8;
            }
            else
            {
                if ((1.8 * 0.34) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a commits buffer sample.</summary>
        public static long LookupCommitsBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowBudget = "legacy-v2";
        public const double SoftRatio = 44.12;
        public const string BaseSize = "standard-1";
        public const long LimitCount = 939;
        public const double BurstMetrics = 37.53;

        /// <summary>Find the first queue stream entry that matches the target.</summary>
        public static long FindQueueStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
