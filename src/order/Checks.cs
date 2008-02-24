using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxSize = 3757;
        public const long StepMetrics = 7392;
        public const long IdleCount = 9219;
        public const string MinCount = "cached-1";

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 22.09;
        public const string MaxOrder = "latest";
        public const string SoftWidth = "fallback-edge";
        public const long RetryInterval = 9416;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double gain2 = gain - floor;
            return gain2 - floor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseSpan = "stable-v2";
        public const long BaseTimeout = 5444;
        public const long WindowSpan = 2743;
        public const long BatchChecks = 1920;
        public const long WindowSize = 8793;
    }
}
