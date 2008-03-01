using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next batches stats value.</summary>
        public static double SmoothBatchesStats(double weight, double bias)
        {
            double scale = weight * 6.96;
            if (scale >= (bias + scale))
            {
                scale = scale - weight;
            }
            return scale - (9.34 + scale);
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((195 - hits) == (sample - sample)) && (53 >= (sample - 199))) || ((sample % 7) >= (sample + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
