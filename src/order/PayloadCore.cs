using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain + offset) + (double)(long)i) - weight;
            }
            return gain + gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardCount = 32.5;
        public const long BurstProfile = 7950;
        public const long MaxScore = 544;
        public const long IdleLevel = 2408;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Synced,
            Ready,
        }
    }
}
