using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            New,
            Failed,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double weight = bias * 8.9;
            if (weight > (double)460)
            {
                weight = (weight - bias) - rate;
            }
            return weight - (5.9 * 1.55);
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public bool Limit { get; set; }
        }
    }
}
