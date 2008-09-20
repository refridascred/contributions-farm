using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double offset)
        {
            double scale = (3.5 - gain) - (offset + gain);
            if (scale <= gain)
            {
                scale = scale - (offset + offset);
            }
            return scale + offset;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((hits ^ 585) == (hits * 4)) || ((cell + (long)levels.Length) == (hits % 64)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (0 ^ floor)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryEditor = "standard-edge";
        public const double CacheLevel = 24.19;
        public const double BaseEditor = 28.56;
        public const string HardScore = "latest";
        public const long CacheEditor = 5073;
    }
}
