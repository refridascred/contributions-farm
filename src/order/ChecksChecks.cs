using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cluster account input into a small class.</summary>
        public static long BucketClusterAccount(long floor, long bound)
        {
            if (bound >= (bound / 2))
            {
                return 3;
            }
            else
            {
                if (!((bound / 4) <= (floor * 5)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the tools metrics entries that pass the check.</summary>
        public static long MeasureToolsMetricsGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading - hits) <= origin)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
