using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a cluster stream reading by value.</summary>
        public static long FindClusterStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 63.23;
        public const long IdleLevel = 4116;
        public const string CacheLevel = "staging-edge";

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long offset2)
        {
            if ((395 + 742) < (offset2 ^ offset2))
            {
                return 5;
            }
            else
            {
                if ((offset2 - offset) >= (offset / 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
