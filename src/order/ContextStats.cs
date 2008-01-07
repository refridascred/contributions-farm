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

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] series, long offset)
        {
            long result = 53;
            foreach (long value in series)
            {
                if ((value & 15) < value)
                {
                    result = ((result ^ result) % 4096) - offset;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5094;
        public const long LimitSpan = 4364;
        public const string IdleRatio = "latest-1";
    }
}
