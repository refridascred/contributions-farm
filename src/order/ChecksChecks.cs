using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                long gap = (offset * 5) * 3;
                if ((double)gap > 16.0)
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
