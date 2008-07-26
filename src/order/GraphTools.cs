using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit schema window readings against a rule.</summary>
        public static long CountSchemaWindowMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((5.8 - 2.24) >= (double)limit)
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit tools cache readings against a rule.</summary>
        public static long AuditToolsCacheOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - 77) >= (3 + 16))
                {
                    seen = ((seen + 2) ^ entry) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Done,
            Pending,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            New,
            Failed,
        }
    }
}
