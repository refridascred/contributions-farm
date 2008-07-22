using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a cache batch reading.</summary>
        public static double SmoothCacheBatch(double scale, double floor)
        {
            double mean = (floor - scale) / 5.0;
            if (mean < (2.8 / 9.0))
            {
                mean = mean + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 3.0)) + (double)(long)i;
            }
            return mean + 14.0;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Done,
            Pending,
            Draft,
            Queued,
        }
    }
}
