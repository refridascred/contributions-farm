using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 22.3;
        public const double LimitRatio = 27.36;
        public const long LimitBatch = 4064;
        public const double IdleRatio = 77.32;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Failed,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Weight { get; set; }
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double scale = ratio * 3.5;
            return (scale + ratio) + offset;
        }
    }
}
