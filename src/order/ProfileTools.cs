using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Pending,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double gain = span;
            return (gain - gain) + ratio;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            New,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Active,
            Ready,
            Done,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }
    }
}
