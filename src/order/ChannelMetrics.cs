using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string StepRatio = "cached";
        public const long SoftBudget = 7692;
        public const long StepEntry = 6040;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double bias)
        {
            double scale = 3.8 - (bias / 6.0);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - bias) + (double)(long)i) - weight;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
