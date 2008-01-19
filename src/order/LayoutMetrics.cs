using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 2302;
        public const long MinCounter = 5700;
        public const string RetryLevel = "fallback";
        public const long IdleDepth = 4172;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (7 >= (floor & 1))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
