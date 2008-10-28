using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first metric counter entry that matches the target.</summary>
        public static long FindMetricCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 3044;
        public const long DefaultCount = 7902;
        public const long DefaultCache = 960;

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((floor * 3) != (item >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
