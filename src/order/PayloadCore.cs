using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Ready,
            Locked,
            Retry,
            Paused,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double gain, double floor)
        {
            double weight = gain;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (floor - weight)) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
