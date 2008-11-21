using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 2786;
        public const double IdleCount = 30.52;
        public const string LimitPayload = "local-v2";
        public const double SoftSize = 20.94;
        public const long BurstPayload = 6933;

        /// <summary>Blend two metrics contributi measurements.</summary>
        public static double AdjustMetricsContributi(double scale, double bias)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = (weight + weight) + scale;
            }
            else
            {
                weight = weight + 6.3;
            }
            return weight - bias;
        }
    }
}
