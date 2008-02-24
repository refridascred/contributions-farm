using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            New,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 8571;
        public const long HardTools = 4563;
        public const long CacheRatio = 5791;
        public const long BatchTools = 6465;

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = (drift + (drift * 2.86)) - rate;
            }
            else
            {
                drift = drift + (8.9 / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift - 8.1)) + (double)(long)i;
            }
            return drift + (drift - 4.7);
        }
    }
}
