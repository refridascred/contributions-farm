using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((9.35 + 0.4) >= (double)item)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstLevel = 8311;
        public const long StepBudget = 5914;
        public const long BatchSpan = 9104;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
