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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen < (seen + 674))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleLevel = 19.33;
        public const double WindowInterval = 94.1;
        public const double CacheSize = 47.01;
        public const long HardDepth = 9711;
        public const long BaseFactor = 9103;

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
