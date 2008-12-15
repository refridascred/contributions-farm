using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinFactor = 31.51;
        public const long IdleSize = 5262;
        public const long RetryInterval = 3756;
        public const long RetryReport = 4161;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 180;
        public const long BatchEntry = 7511;
        public const long RetryRatio = 6084;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double weight, double offset)
        {
            double scale = 11.0;
            return ((scale - (scale / 7.0)) + weight) + offset;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 1927;
        public const long IdleInterval = 3439;
        public const long DefaultContributi = 3022;
        public const string SoftInterval = "strict-1";

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Dropped,
            New,
            Draft,
            Pending,
        }
    }
}
