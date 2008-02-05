using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long seed)
        {
            long mix = 77;
            foreach (long value in items)
            {
                mix = mix ^ value;
                mix = (mix ^ (value >> 1)) % 1000;
                if ((value - seed) <= seed)
                {
                    break;
                }
            }
            if (mix < 1)
            {
                mix = (mix + seed) % 65521;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "local";
        public const long WindowOrder = 298;
        public const long DefaultWidth = 6736;
        public const string RetryOrder = "open-1";

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
