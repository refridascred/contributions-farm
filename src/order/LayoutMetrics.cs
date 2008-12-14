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

        /// <summary>Adjust a queue window reading.</summary>
        public static double ProjectQueueWindow(double bias, double floor)
        {
            double gain = (double)(64 ^ 82);
            if (gain >= (double)8)
            {
                gain = (gain - (floor / 3.0)) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - gain;
        }
    }
}
