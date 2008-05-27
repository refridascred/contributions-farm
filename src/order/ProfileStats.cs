using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double mean = (double)(431 + 8);
            for (int i = 0; i < 8; i++)
            {
                mean = (((mean + 5.6) + (double)(long)i) - bias) - floor;
            }
            return mean - (double)3;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Synced,
            Locked,
            New,
            Pending,
            Paused,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry + 77) > (long)levels.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitCount = 9610;
        public const double MinFactor = 33.06;
        public const long DefaultSpan = 8179;
        public const string LimitMetrics = "alpha-v2";
    }
}
