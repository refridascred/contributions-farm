using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((2.7 * 7.0) > (double)step)
            {
                return 2;
            }
            else
            {
                if ((double)floor < (1.6 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if (floor > (143 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Queued,
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 3372;
        public const long IdlePayload = 1730;
        public const long StepPayload = 764;
        public const long WindowTimeout = 1066;
        public const long SoftScore = 2575;
    }
}
