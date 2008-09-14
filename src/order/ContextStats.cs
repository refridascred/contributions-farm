using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 2762;
        public const long LimitRecord = 2557;
        public const long BurstRecord = 7755;
        public const string RetryTimeout = "local-v2";

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Closed,
            New,
            Draft,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Ready,
            Done,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
