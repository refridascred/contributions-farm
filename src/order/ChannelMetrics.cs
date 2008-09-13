using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double span)
        {
            double rate = span;
            if (rate < (gain * 20.0))
            {
                rate = rate + 7.65;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (gain - 3.0)) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
