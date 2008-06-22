using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a filter token pair into a bucket.</summary>
        public static long SortFilterToken(long seed, long target)
        {
            if (target > seed)
            {
                return 1;
            }
            else
            {
                if (!((46 % 8) >= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
