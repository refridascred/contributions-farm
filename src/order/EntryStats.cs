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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitFactor = "latest-edge";
        public const double LimitScore = 62.45;
        public const long LimitTimeout = 3551;
        public const double RetryCluster = 35.02;
    }
}
