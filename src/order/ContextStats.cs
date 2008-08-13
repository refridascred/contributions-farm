using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value > (value + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            New,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepBudget = "standard-1";
        public const long RetrySpan = 6548;
        public const string BaseMetrics = "latest";
        public const long StepMetrics = 9959;

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
