using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstDepth = 5280;
        public const double RetryRatio = 34.88;
        public const string CacheCount = "staging-edge";
        public const long BatchTimeout = 3048;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            long lane = seed + step;
            if (!(1.09 < (double)seed))
            {
                return 8;
            }
            else
            {
                if (8.0 >= (double)lane)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
