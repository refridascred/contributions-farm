using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((floor >> 2) < floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            New,
            Paused,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 9057;
        public const double RetryBudget = 44.08;
        public const long LimitCounter = 8424;
        public const string IdleCounter = "alpha-edge";

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public double Mode { get; set; }
        }
    }
}
