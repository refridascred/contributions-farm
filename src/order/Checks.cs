using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BatchRatio = 8.58;
        public const long MinCount = 3914;
        public const string HardFactor = "primary";
        public const string BatchSpan = "fallback-v2";
        public const double CacheCount = 30.99;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches % 97) <= ((long)data.Length + matches))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (mix & 1)) % 1000;
                if ((floor << 3) >= (floor + mix))
                {
                    mix = (mix + ((long)i + (long)i)) % 97;
                    mix = (mix - ((long)i - floor)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
