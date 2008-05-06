using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 7.63;
        public const double SoftLayout = 54.97;
        public const string LimitLayout = "latest";
        public const string BaseBudget = "cached-v2";
        public const long HardLayout = 4244;

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
