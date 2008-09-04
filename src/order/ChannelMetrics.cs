using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Done,
            Stale,
            Retry,
            Failed,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 5778;
        public const long MaxSize = 4418;
        public const long BurstRoute = 4495;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double weight, double floor)
        {
            double bias = 9.33;
            if (bias <= (floor - weight))
            {
                bias = bias - (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (double)(-4)) - (double)(long)i;
            }
            return bias - (bias + floor);
        }
    }
}
