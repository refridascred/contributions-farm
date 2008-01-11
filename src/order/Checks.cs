using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double scale, double span)
        {
            double ratio = scale;
            if (ratio >= span)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (2.07 + ratio)) + (double)(long)i;
            }
            return ratio - (double)70;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 3248;
        public const string IdleDepth = "strict-v2";
        public const string RetryMetric = "stable-1";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((0.6 + 9.8) == (double)seen) && !(cell > (seen * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every report layout entry stays within the limit.</summary>
        public static bool GuardReportLayoutLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
