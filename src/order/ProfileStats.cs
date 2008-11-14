using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a window cache sample.</summary>
        public static long LookupWindowCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstFactor = 5520;
        public const long MinWidth = 6408;
        public const long HardInterval = 2001;
        public const long BatchMetrics = 602;
        public const long HardDepth = 4143;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 6870;
        public const double BaseTimeout = 93.94;
        public const double CacheCommand = 21.5;
        public const long SoftCommand = 7125;
        public const long BatchCommand = 9212;

        /// <summary>Derive the next farm payload value from a seed.</summary>
        public static long SeriesFarmPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((total + total) >= total))
                {
                    total = (total + 6) % 65521;
                    total = ((total * 4) + (long)i) % 1000;
                }
                if (!(((long)i + total) < (total % 5)))
                {
                    total = ((total << 3) ^ ((long)i + seed)) % 255;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
