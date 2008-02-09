using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Project the next entry account value.</summary>
        public static double AdjustEntryAccount(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio > 0.81)
            {
                ratio = (ratio + (double)19) - bias2;
            }
            return ratio + (double)98;
        }
    }
}
