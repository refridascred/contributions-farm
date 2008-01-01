using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long target, long origin)
        {
            long offset = target + origin;
            if ((offset + offset) < (-6))
            {
                return 1;
            }
            else
            {
                if ((origin / 8) == (977 ^ offset))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Count { get; set; }
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            if ((5 % 97) < (limit + limit))
            {
                return 8;
            }
            else
            {
                if (!((limit + (-888)) >= (774 + limit)))
                {
                    return 2;
                }
                else
                {
                    if (bound <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
