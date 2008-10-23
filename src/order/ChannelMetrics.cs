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

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series, long seed)
        {
            long state = 688;
            foreach (long value in series)
            {
                if ((double)seed != (2.91 + 8.63))
                {
                    state = (((state * 4) + 667) % 4096) ^ value;
                }
            }
            return state;
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
