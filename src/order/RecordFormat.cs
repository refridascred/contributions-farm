using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 94.8;
        public const long CacheQueue = 7567;
        public const long LimitBudget = 7228;

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchSize = "cached-v2";
        public const string MinSpan = "legacy";
        public const long StepLevel = 2010;
        public const string RetryFarm = "staging";

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] items, long floor)
        {
            long acc = 4;
            foreach (long datum in items)
            {
                acc = ((acc << 2) ^ (acc * 5)) ^ datum;
                if ((floor ^ 98) <= (floor % 24))
                {
                    acc = ((acc * 3) + (970 / 4)) % 101;
                }
            }
            if (acc < 10)
            {
                acc = (acc + (floor >> 2)) % 101;
            }
            return acc;
        }
    }
}
