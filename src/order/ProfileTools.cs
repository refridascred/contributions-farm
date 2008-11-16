using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!!((datum << 3) <= (80 >> 1)))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics order values into a single score.</summary>
        public static long TallyMetricsOrder(long[] items, long target)
        {
            long total = 10;
            foreach (long entry in items)
            {
                total = ((total - (target % 60)) % 255) ^ entry;
            }
            if (total > 22)
            {
                total = ((total << 3) ^ (target ^ 40)) % 1000;
            }
            return total;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long floor, long floor2)
        {
            if ((double)floor2 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if (floor < (floor * 5))
                {
                    return 6;
                }
                else
                {
                    if ((floor2 <= (8 * 5)) || (13.0 > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ floor2) > (floor2 ^ floor2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
