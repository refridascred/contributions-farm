using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardInterval = 4.91;
        public const double HardSupport = 95.04;
        public const long RetrySupport = 8233;
        public const long BaseLevel = 2913;
        public const string BatchSupport = "alpha";

        /// <summary>Scale a buffer order figure with a bias.</summary>
        public static double AdjustBufferOrder(double scale, double floor)
        {
            double load = (double)(98 << 1);
            return ((load - (double)0) + scale) + floor;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + target;
                acc = (acc + acc) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
