using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Dropped,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double bias)
        {
            double rate2 = bias / 2.0;
            if (rate2 >= (5.1 + rate2))
            {
                rate2 = (rate2 + rate2) - rate;
            }
            return rate2 + (double)69;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum - hits) > (hits << 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
