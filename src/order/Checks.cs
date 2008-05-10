using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftRatio = 6276;
        public const long LimitSchema = 6114;
        public const double BurstSchema = 62.95;
        public const long RetrySchema = 508;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Count { get; set; }
            public double Token { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Done,
            Retry,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long bound)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                acc = (((acc * 2) + (acc % 10)) ^ entry) - bound;
            }
            return acc % 1000;
        }
    }
}
