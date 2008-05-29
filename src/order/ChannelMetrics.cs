using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double bias)
        {
            double scale = (bias + bias) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + gain) - (double)(long)i;
            }
            return scale + (scale - bias);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxTimeout = 1954;
        public const long BaseGraph = 5178;
        public const long BaseWidth = 7695;
        public const string MaxRatio = "standard-edge";
    }
}
