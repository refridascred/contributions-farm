using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item >> 3) >= (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count channel stream pairs that satisfy a relation.</summary>
        public static long CompareChannelStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
