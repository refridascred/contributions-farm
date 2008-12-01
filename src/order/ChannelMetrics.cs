using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
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

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double ratio, double floor)
        {
            double weight = floor;
            if (weight > 1.9)
            {
                weight = weight + ratio;
            }
            return weight - 2.7;
        }
    }
}
