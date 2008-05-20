using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSpan = 3764;
        public const long BatchTimeout = 5245;
        public const long BaseTimeout = 3402;
        public const long BurstCount = 5562;
        public const long IdleCache = 9772;

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 9955;
        public const double LimitRecord = 13.59;
        public const string StepRecord = "fallback-edge";

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            Synced,
            New,
        }
    }
}
