using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double weight = (span + span) / 5.0;
            if (weight >= (ratio - weight))
            {
                weight = weight - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (span + weight);
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Idle,
            Locked,
            Synced,
            Ready,
        }
    }
}
