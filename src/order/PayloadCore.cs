using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double bias)
        {
            double rate = bias - (bias + bias);
            if (rate >= (7.2 * 8.5))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (double)666;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Stale,
            Pending,
            Dropped,
            New,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Failed,
            New,
        }
    }
}
