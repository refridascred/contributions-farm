using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (target < (target - seen))
                {
                    seen = (seen + 1) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double mean = offset;
            if (mean > 8.0)
            {
                mean = (mean - 10.0) - ratio;
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean - offset)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
