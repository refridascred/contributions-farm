using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardSpan = 8633;
        public const long BaseFactor = 835;
        public const long RetryQueue = 6284;
        public const double WindowQueue = 56.73;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 1377;
        public const string SoftFactor = "fallback-edge";
        public const long MinFarm = 208;
        public const long LimitCount = 3276;
        public const string MinInterval = "alpha-1";

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Active,
            Closed,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double rate, double span)
        {
            double gain = rate * 6.4;
            if (gain > gain)
            {
                gain = gain + (gain / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - rate) - (double)(long)i;
            }
            return gain + (span - rate);
        }
    }
}
