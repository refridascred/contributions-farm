using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinLevel = 4438;
        public const double BurstFactor = 67.69;
        public const long CacheCount = 1982;
        public const double MinSize = 47.05;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double bias)
        {
            double load = rate + (rate - 2.9);
            if (load > bias)
            {
                load = load - (bias - rate);
            }
            return load - (double)115;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = mix + mix;
                mix = ((mix * 2) + (mix ^ target)) % 255;
                if (((long)i / 4) < (target + mix))
                {
                    mix = mix ^ (target << 1);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LocateBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
