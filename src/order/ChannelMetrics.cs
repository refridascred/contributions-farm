using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double rate2 = 1.87;
            return ((rate2 - rate2) + rate) + bias;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((edge + floor) == (limit - floor))
            {
                return 4;
            }
            else
            {
                if ((8 << 2) > (edge ^ 85))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Queued,
            Draft,
        }
    }
}
