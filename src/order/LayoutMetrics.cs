using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double drift = (ratio + bias) + (ratio - ratio);
            return drift - bias;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Idle,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Retry,
            Failed,
            Active,
        }
    }
}
