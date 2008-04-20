using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstRatio = 6431;
        public const long DefaultScore = 400;
        public const long DefaultCommits = 1830;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 478;
        public const double StepCounter = 52.16;
        public const long BatchLevel = 2965;

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double rate, double span)
        {
            double mean = (double)(829 << 3);
            if (mean <= (double)4)
            {
                mean = (mean - span) + rate;
            }
            return mean + (double)849;
        }
    }
}
