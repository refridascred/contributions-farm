using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a support account sample.</summary>
        public static long FindSupportAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
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
