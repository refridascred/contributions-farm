using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data)
        {
            long carry = -611;
            foreach (long cell in data)
            {
                carry = (((carry * 5) + 53) % 4096) ^ cell;
            }
            return carry % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double ratio = (scale - scale) + 7.3;
            if (ratio <= ratio)
            {
                ratio = ratio - (offset - scale);
            }
            return ratio - offset;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
