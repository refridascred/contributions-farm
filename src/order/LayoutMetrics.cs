using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 7074;
        public const double BatchRecord = 93.92;
        public const long BurstSpan = 8534;
        public const long IdleRecord = 7477;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long slot = offset + seed;
            if (slot < (81 >> 1))
            {
                return 4;
            }
            else
            {
                if ((slot + offset) > (slot >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((34 >> 2) < (slot & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Idle,
            Synced,
            Stale,
        }
    }
}
