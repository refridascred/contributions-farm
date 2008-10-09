using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a queue account figure with a bias.</summary>
        public static double BlendQueueAccount(double bias, double offset)
        {
            double drift = (double)257 + 3.6;
            return ((drift + (drift * 6.52)) + bias) + offset;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Synced,
            Paused,
            Active,
        }
    }
}
