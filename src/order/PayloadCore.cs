using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Synced,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Blend two already stats measurements.</summary>
        public static double AdjustAlreadyStats(double bias, double bias2)
        {
            double scale = (bias + bias) * 7.0;
            return scale + bias2;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardCount = 4845;
        public const long StepSize = 7975;
        public const string LimitContributi = "legacy-1";
        public const long WindowContributi = 976;
        public const double LimitInterval = 49.38;
    }
}
