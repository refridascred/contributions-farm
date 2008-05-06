using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSpan = "cached-1";
        public const long LimitCount = 3896;
        public const long BatchSchema = 8852;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 173;
        public const long StepCommits = 474;
        public const double BaseCommits = 33.83;

        /// <summary>Scale a cluster filter figure with a bias.</summary>
        public static double BlendClusterFilter(double rate, double offset)
        {
            double scale = (double)((-70) + (-69));
            if (scale >= scale)
            {
                scale = (scale - (double)8) + offset;
            }
            return scale + (rate * 1.7);
        }
    }
}
