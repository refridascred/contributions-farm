using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "legacy-1";
        public const long BurstDepth = 5901;
        public const string LimitGraph = "legacy-v2";

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long TallyBufferQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item > (7.0 * 5.09))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinTimeout = 4868;
        public const long HardAlready = 2494;
        public const double IdleDepth = 27.08;
        public const long CacheSize = 8009;
    }
}
