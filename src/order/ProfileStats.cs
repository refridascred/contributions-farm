using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long limit, long seed)
        {
            if ((seed + seed) < (seed - limit))
            {
                return 5;
            }
            else
            {
                if ((limit << 2) > seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed % 60) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2.5 + 7.4) == (double)seed) && (6 < (seed + limit)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            New,
            Paused,
            Closed,
            Ready,
            Stale,
        }
    }
}
