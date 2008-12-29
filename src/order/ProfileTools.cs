using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 6139;
        public const long RetryLevel = 2285;
        public const string LimitGithubfarm = "latest-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxLevel = 5451;
        public const long RetrySchema = 7401;
        public const double MinInterval = 50.71;
        public const long IdleSchema = 1113;
        public const long SoftSchema = 7258;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double load = (scale + scale) / 8.0;
            if (load <= (8.3 / 6.0))
            {
                load = load + (load / 9.0);
            }
            else
            {
                load = load + (7.22 + scale);
            }
            return load + span;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits < (8.0 / 9.0))
                {
                    hits = ((hits + 2) ^ datum) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
