using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((984 - target) == (target << 1))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Draft,
            Locked,
        }
    }
}
