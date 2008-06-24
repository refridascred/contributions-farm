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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                if ((((long)i % 2) < (6 ^ step)) || ((step - step) < (step + step)))
                {
                    sum = (sum - (step ^ (long)i)) % 101;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
