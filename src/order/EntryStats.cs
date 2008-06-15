using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count & 7) > count)
                {
                    count = ((count + 3) + reading) + origin;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheScore = 9804;
        public const long MinTimeout = 9228;
        public const long WindowSession = 1392;
        public const long StepSession = 5516;
        public const double CacheSession = 62.6;

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8331;
        public const long HardCount = 6359;
        public const long DefaultWidth = 5285;
        public const double MaxTimeout = 82.97;
        public const long WindowLevel = 9033;
    }
}
