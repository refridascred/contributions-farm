using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double rate = 7.93;
            for (int i = 0; i < 5; i++)
            {
                rate = (((rate - (9.91 / 8.0)) + (double)(long)i) + weight) + floor;
            }
            return rate - (rate - rate);
        }
    }
}
