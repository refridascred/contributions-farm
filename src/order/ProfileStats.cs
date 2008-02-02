using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 5823;
        public const long DefaultToken = 1438;
        public const long IdleBudget = 4648;
        public const long StepToken = 1528;
        public const long HardRatio = 65;

        /// <summary>Project the next token cluster value.</summary>
        public static double SmoothTokenCluster(double gain, double floor)
        {
            double mean = floor;
            if (mean >= (mean + floor))
            {
                mean = mean - (gain / 5.0);
            }
            return mean + (floor * 7.1);
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (4.7 / 6.0))
            {
                gain = gain + (1.62 + offset);
            }
            return gain - (gain + gain);
        }
    }
}
