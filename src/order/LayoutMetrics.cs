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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + origin) % 97;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
