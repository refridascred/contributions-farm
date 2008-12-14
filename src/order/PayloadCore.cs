using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7428;
        public const string RetrySpan = "strict-v2";
        public const long RetryTimeout = 2406;
        public const string SoftWindow = "stable-edge";
        public const long SoftFactor = 7330;

        /// <summary>Define session limits and defaults.</summary>
        public const double RetryScore = 0.41;
        public const long MaxSession = 5023;
        public const string RetrySession = "stable-edge";
        public const long CacheDepth = 5987;

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double gain, double span)
        {
            double drift = (double)(305 << 2);
            if (drift <= (gain - span))
            {
                drift = drift + (gain * 6.6);
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (5.5 + 7.2);
        }
    }
}
