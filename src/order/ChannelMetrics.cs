using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double drift = (double)((-75) * 4);
            return ((drift - (double)2) + weight) + span;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }
    }
}
