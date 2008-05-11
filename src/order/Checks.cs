using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepInterval = 3755;
        public const long CacheAccount = 1972;
        public const string BatchFactor = "legacy";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ origin;
                if ((double)total > 4.0)
                {
                    continue;
                }
                else
                {
                    total = (total - (long)i) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of cache filter entries.</summary>
        public static long TallyCacheFilter(long[] data, long offset)
        {
            long sum = 34;
            foreach (long datum in data)
            {
                sum = ((sum * 5) + (offset + sum)) + datum;
            }
            if (sum < 59)
            {
                sum = sum ^ (sum + 24);
            }
            return sum;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 1024;
        public const string IdleSize = "alpha";
        public const string MaxBuffer = "staging";
    }
}
