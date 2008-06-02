using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double scale, double offset)
        {
            double scale2 = (scale - offset) * 15.0;
            if (scale2 < 7.3)
            {
                scale2 = scale2 - (4.0 + 9.0);
            }
            return scale2 - 2.5;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 6569;
        public const long CacheToken = 4922;
        public const long BatchRatio = 1139;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((80 / 4) < (reading - tally))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }
    }
}
