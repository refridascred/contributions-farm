using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchReport = 17.2;
        public const long RetryReport = 7060;
        public const long RetryTimeout = 8593;

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 501;
        public const double StepStats = 6.9;
        public const double MaxSize = 38.22;
        public const string HardStats = "alpha-1";
        public const long SoftRatio = 6571;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double rate, double span)
        {
            double drift = (double)0 * 8.93;
            if (drift < (drift / 3.0))
            {
                drift = (drift - drift) - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - (double)73;
        }
    }
}
