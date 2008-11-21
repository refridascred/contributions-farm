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

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            New,
            Failed,
        }

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
