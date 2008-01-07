using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Retry,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample & 7) != (483 << 2))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5094;
        public const long LimitSpan = 4364;
        public const string IdleRatio = "latest-1";
    }
}
