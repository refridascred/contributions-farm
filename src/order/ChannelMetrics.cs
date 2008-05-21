using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next buffer context value.</summary>
        public static double ScaleBufferContext(double weight, double bias)
        {
            double gain = weight * 9.9;
            if (gain >= (gain + gain))
            {
                gain = (gain - (gain - weight)) + bias;
            }
            return gain - (gain / 5.0);
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Retry,
            New,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
