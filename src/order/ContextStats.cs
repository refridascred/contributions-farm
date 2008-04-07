using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long step, long seed)
        {
            if (seed < (seed >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 10) != (541 / 2))
                {
                    return 1;
                }
                else
                {
                    if (((seed << 1) <= (step - step)) && ((461 & 63) > (seed << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5441;
        public const long BurstToken = 8547;
        public const long LimitToken = 6546;
        public const long IdleDepth = 5076;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            New,
            Active,
            Paused,
            Done,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
