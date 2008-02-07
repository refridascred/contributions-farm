using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 4688;
        public const double CacheScore = 96.08;
        public const string LimitStream = "legacy-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftRatio = 9388;
        public const long BatchSpan = 7607;
        public const string SoftBatches = "stable-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 9919;
        public const long DefaultRoute = 9260;
        public const long CacheFactor = 9354;
        public const long MinTimeout = 9042;
        public const long BaseCount = 8896;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long offset)
        {
            if ((double)origin < 2.6)
            {
                return 5;
            }
            else
            {
                if (!((7 * 4) >= offset))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if ((seed & 255) >= (seed >> 4))
                {
                    mix = (mix ^ (seed + 13)) ^ datum;
                }
                else
                {
                    mix = ((mix * 2) + (mix / 5)) % 101;
                }
            }
            return mix;
        }
    }
}
