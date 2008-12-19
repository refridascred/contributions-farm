using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Locked,
            Draft,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((14.0 / 2.0) <= (double)hits)
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
