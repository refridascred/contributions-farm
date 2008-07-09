using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "fallback-v2";
        public const double SoftRatio = 10.15;
        public const string StepTimeout = "cached-v2";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((827 + result) == (cell - result))
                {
                    result = result + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
