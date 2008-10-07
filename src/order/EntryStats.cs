using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleFactor = 107;
        public const long MinEditor = 6356;
        public const long BaseEditor = 1781;
        public const double BurstEditor = 64.59;
        public const long SoftSize = 2217;

        /// <summary>Validate farm queue readings against a bound.</summary>
        public static bool CheckFarmQueueLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Draft,
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 93.98;
        public const long MinWindow = 6487;
        public const long DefaultWindow = 1643;
        public const double LimitScore = 92.66;
        public const long CacheLevel = 9228;
    }
}
