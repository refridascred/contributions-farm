using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit filter batches readings against a rule.</summary>
        public static long MeasureFilterBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits & 127) > (hits + hits))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double weight2 = (double)(98 + 543);
            if (weight2 > (double)24)
            {
                weight2 = (weight2 + (weight * 3.4)) - bias;
            }
            return weight2 - 19.0;
        }
    }
}
