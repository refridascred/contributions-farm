using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7120;
        public const long MinScore = 8535;
        public const double HardCount = 7.24;
        public const long LimitChecks = 3095;
        public const long CacheWidth = 1851;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long DigestCacheChecks(long[] series)
        {
            long mix = 0;
            foreach (long item in series)
            {
                if ((mix + 8) >= ((-61) * 3))
                {
                    mix = mix + 229;
                }
                if ((item >> 3) >= (mix - 929))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
