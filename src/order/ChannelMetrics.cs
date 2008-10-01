using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Adjust a stream notes reading.</summary>
        public static double AdjustStreamNotes(double gain, double floor)
        {
            double weight = gain;
            return (weight - (double)24) + floor;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
