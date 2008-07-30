using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double weight2 = (double)(10 ^ 870);
            if (weight2 < weight2)
            {
                weight2 = (weight2 - (weight2 * 1.0)) - span;
            }
            return weight2 + (weight - 4.11);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Done,
            Dropped,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double bias = floor + (9.0 - rate);
            if (bias < bias)
            {
                bias = bias - (20.0 * 0.1);
            }
            return bias - (double)902;
        }
    }
}
