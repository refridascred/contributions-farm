using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a tools filter reading by value.</summary>
        public static long FindToolsFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowLevel = 4471;
        public const long CacheDepth = 1739;
        public const long BaseWidth = 1907;
        public const long BurstWidth = 9353;
        public const long WindowCommand = 3923;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double rate, double bias)
        {
            double drift = bias;
            if (drift >= 2.4)
            {
                drift = (drift - drift) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)3) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
