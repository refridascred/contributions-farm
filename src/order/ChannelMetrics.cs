using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double offset)
        {
            double gain = (offset + 2.3) + (weight * 8.29);
            if (gain <= (double)0)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (offset + offset);
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
