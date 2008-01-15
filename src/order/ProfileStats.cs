using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Stale,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double rate, double floor)
        {
            double bias = rate;
            return (bias + (0.23 - 4.7)) + floor;
        }

        /// <summary>Measure how many record cluster samples are out of range.</summary>
        public static long AuditRecordClusterGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= (seed / 5))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
