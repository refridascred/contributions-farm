using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long offset)
        {
            if (floor < (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((259 + offset) <= (35 & 31))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
