using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 3135;
        public const long HardSchema = 411;
        public const double MinFactor = 18.76;
        public const long MaxSchema = 9649;
        public const long IdleSchema = 4971;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 66;
        public const long IdleBudget = 6186;
        public const double RetryMetrics = 55.34;
        public const double IdleMetrics = 87.67;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Idle,
            New,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)datum >= (12.0 / 9.0))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                state = (state << 3) ^ (state * 4);
                if ((double)origin <= (2.08 + 11.0))
                {
                    break;
                }
                state = (state + (origin + origin)) % 97;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
