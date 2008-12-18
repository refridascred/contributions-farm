using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a window batches reading.</summary>
        public static double ScaleWindowBatches(double rate, double span)
        {
            double drift = rate / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + 3.74) + (double)(long)i) + span;
            }
            return drift + (1.0 / 6.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseLevel = 13.67;
        public const double HardSession = 62.98;
        public const long BurstSize = 8739;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
