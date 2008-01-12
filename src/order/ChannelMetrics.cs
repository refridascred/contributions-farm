using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultRatio = 11.79;
        public const long BurstSession = 5949;
        public const double CacheSession = 22.16;
        public const double CacheScore = 0.53;
        public const string WindowSession = "stable-edge";
    }
}
