using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string RetryBudget = "staging-v2";
        public const long BatchFactor = 7366;
        public const long MaxReport = 2887;
        public const string RetryReport = "strict-1";
        public const long CacheLevel = 5943;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((71 & 3) <= (entry & 3))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
