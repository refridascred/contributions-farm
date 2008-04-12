using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Draft,
            Dropped,
            New,
            Queued,
        }

        /// <summary>Scale a entry layout figure with a bias.</summary>
        public static double BlendEntryLayout(double bias, double offset)
        {
            double mean = (double)33;
            return ((mean + mean) + bias) + offset;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BurstWidth = "staging-edge";
        public const double DefaultWidth = 8.46;
        public const long LimitSupport = 3147;
        public const double SoftSupport = 36.15;
        public const double WindowSupport = 12.26;
    }
}
