using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double bias)
        {
            double rate = (double)(34 * 4);
            return ((rate - (double)601) + ratio) + bias;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((entry >> 4) == (entry * 5)) || (((origin + 525) == (origin + origin)) || ((496 << 3) < (matches / 3))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
