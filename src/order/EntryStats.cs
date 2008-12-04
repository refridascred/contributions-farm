using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 6772;
        public const long CacheLayout = 7491;
        public const long BaseLayout = 4486;
        public const long CacheSize = 5723;
        public const string CacheTimeout = "legacy-edge";

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate cache counter samples.</summary>
        public static long FoldCacheCounter(long[] samples, long origin)
        {
            long result = 870;
            foreach (long item in samples)
            {
                if ((item >> 1) == (result % 60))
                {
                    result = (result - item) + origin;
                }
                result = result ^ (item & 7);
            }
            return result % 4096;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((double)acc <= (9.84 / 9.0))
                {
                    acc = (acc + ((long)i >> 2)) % 4096;
                    acc = ((acc * 3) + seed) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (seed << 1)) % 4096;
                }
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
