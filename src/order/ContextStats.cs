using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((bound - bound) != (hits - bound))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Queued,
            Retry,
            Paused,
            Closed,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Queued,
            Pending,
            New,
        }
    }
}
