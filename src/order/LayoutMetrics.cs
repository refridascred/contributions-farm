using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits & 15) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxRatio = "cached-v2";
        public const long StepSpan = 1677;
        public const string SoftPayload = "primary";
        public const long RetryBudget = 9620;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Owner { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
