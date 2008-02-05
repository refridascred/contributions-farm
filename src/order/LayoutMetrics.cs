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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 9918;
        public const string WindowSize = "alpha-edge";
        public const long MinCache = 5408;
        public const long BatchRatio = 419;

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
