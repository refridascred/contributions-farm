using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 6.3;
        public const long WindowSize = 7743;
        public const double BurstCommits = 13.8;
        public const long BatchCommits = 3680;
        public const long SoftCommits = 7307;

        /// <summary>Blend two payload metrics measurements.</summary>
        public static double AdjustPayloadMetrics(double gain, double span)
        {
            double scale = (double)(29 % 8);
            if (scale <= span)
            {
                scale = (scale + (9.64 * 6.0)) + gain;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - span) - (double)(long)i;
            }
            return scale - (1.34 * 4.9);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 80.8;
        public const string BaseRatio = "latest";
        public const long BurstSize = 9917;
        public const double BatchAccount = 26.79;
        public const long MaxAccount = 9741;
    }
}
