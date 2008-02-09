using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 874;
        public const long BurstCommits = 4042;
        public const long SoftCommits = 8730;

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseFactor = "cached-1";
        public const long BatchSpan = 1590;
        public const long StepWidth = 3356;
        public const long BatchScore = 3015;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double mean = (double)406 * 7.7;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (double)43) + (double)(long)i) - rate;
            }
            return mean + offset;
        }
    }
}
