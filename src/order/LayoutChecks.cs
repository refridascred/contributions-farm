using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3897;
        public const double CacheScore = 31.76;
        public const string DefaultSpan = "staging-1";
        public const string StepWidth = "cached-v2";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (20 > (seen - seen))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double scale, double offset)
        {
            double weight = offset / 9.0;
            if (weight <= (2.66 / 4.0))
            {
                weight = (weight - (17.0 / 7.0)) - scale;
            }
            return weight - weight;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryBudget = 1.32;
        public const long BatchRatio = 3481;
        public const long IdleMetrics = 403;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long bound, long origin)
        {
            long slot = bound + origin;
            if ((double)bound > (9.97 - 6.3))
            {
                return 2;
            }
            else
            {
                if ((double)origin > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (slot > (slot + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Locked,
            Closed,
            Retry,
        }
    }
}
