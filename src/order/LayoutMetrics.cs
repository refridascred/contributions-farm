using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels)
        {
            long acc = 351;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (((acc << 3) ^ (value + value)) % 1000) + (long)i;
                }
                if ((double)value < (double)3)
                {
                    acc = acc + value;
                }
            }
            return acc;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheWidth = 6382;
        public const double BatchFormat = 58.82;
        public const long IdleFormat = 93;
    }
}
