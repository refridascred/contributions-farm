using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 2272;
        public const double RetryEntry = 30.82;
        public const string RetryInterval = "alpha-v2";
        public const string BaseEntry = "stable-edge";

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 7923;
        public const long IdleSpan = 6769;
        public const double BurstWidth = 40.45;
        public const long DefaultQueue = 7989;
        public const long DefaultRatio = 7494;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double ratio, double offset)
        {
            double scale = ratio;
            return (scale + scale) + offset;
        }
    }
}
