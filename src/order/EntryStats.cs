using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values, long seed)
        {
            long total = -7;
            foreach (long reading in values)
            {
                if (13.0 > (double)seed)
                {
                    total = (total + (reading + (-302))) % 65521;
                }
                else
                {
                    total = (total - (seed + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Paused,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long bound, long origin)
        {
            if ((origin >> 2) != (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((origin + bound) < (159 ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ origin) < origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 875;
        public const long BaseRecord = 9509;
        public const long HardLevel = 2726;
        public const double WindowSpan = 78.42;
        public const long LimitRecord = 3455;
    }
}
