using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits + 985) <= (hits >> 3))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Failed,
            Draft,
        }
    }
}
