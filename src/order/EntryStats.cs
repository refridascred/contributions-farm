using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long limit, long offset)
        {
            if (limit > (limit << 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (17.0 * 4.9))
                {
                    return 2;
                }
                else
                {
                    if (!((limit + 735) > (limit - 89)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset >> 1))
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
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long target)
        {
            if ((target ^ floor) < floor)
            {
                return 8;
            }
            else
            {
                if ((target + target) <= target)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 6216;
        public const string IdleWidth = "standard-1";
        public const long DefaultSize = 1871;
        public const double BaseTimeout = 54.41;
    }
}
