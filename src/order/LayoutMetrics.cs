using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every profile filter entry stays within the limit.</summary>
        public static bool ValidateProfileFilterLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 6870;
        public const long MinLevel = 3403;
        public const string SoftMetric = "legacy-1";
        public const long RetrySpan = 33;
        public const long StepSize = 2578;
    }
}
