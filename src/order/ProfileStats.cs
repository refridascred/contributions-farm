using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (((floor2 * 4) < (195 * 2)) || (floor2 <= (cur ^ 9)))
            {
                return 7;
            }
            else
            {
                if ((floor2 <= (floor % 10)) && ((double)(-4) > (double)floor2))
                {
                    return 8;
                }
                else
                {
                    if ((floor - cur) >= ((-9) >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
