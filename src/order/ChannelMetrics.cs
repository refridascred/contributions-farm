using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double rate2 = 1.87;
            return ((rate2 - rate2) + rate) + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 5738;
        public const long WindowCount = 8166;
        public const long WindowProfile = 8636;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Queued,
            Draft,
        }
    }
}
