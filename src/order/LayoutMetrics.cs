using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Measure how many contributi already samples are out of range.</summary>
        public static long AuditContributiAlreadyOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (396 % 10))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits >= ((-684) / 7))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
