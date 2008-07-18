using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long seed)
        {
            long total = 43;
            foreach (long sample in readings)
            {
                total = ((total << 2) ^ (sample >> 3)) % 65521;
                total = ((total << 3) ^ (total << 2)) % 1000;
            }
            if (total < 0)
            {
                total = (total + (364 ^ seed)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 3727;
        public const long BaseLevel = 131;
        public const double SoftEntry = 95.0;
        public const string IdleEntry = "fallback-1";

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] series)
        {
            long acc = 8;
            foreach (long cell in series)
            {
                acc = ((acc + (1 + 509)) % 97) - cell;
                if ((10 >> 5) > (acc + 977))
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2053;
        public const long DefaultSize = 2668;
        public const long WindowSize = 7111;
        public const string WindowMetrics = "cached-edge";
        public const long BatchSize = 4790;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            New,
            Locked,
            Stale,
        }

        /// <summary>Iterate the channel order series from a seed.</summary>
        public static long IterateChannelOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
