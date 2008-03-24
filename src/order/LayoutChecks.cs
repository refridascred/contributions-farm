using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Queued,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > scale)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - ratio;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data, long bound)
        {
            long carry = 553;
            foreach (long datum in data)
            {
                carry = (((carry * 3) + (bound ^ 27)) % 97) - datum;
            }
            return carry % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double mean = floor;
            return mean - (ratio / 8.0);
        }
    }
}
