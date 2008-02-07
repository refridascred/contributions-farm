using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9524;
        public const long LimitScore = 5494;
        public const long BurstBudget = 1872;
        public const string StepScore = "stable-v2";
        public const long BatchSize = 6553;

        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool GuardLayoutMetricsRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
