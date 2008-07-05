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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long offset, long floor)
        {
            long gap = offset - floor;
            if ((double)offset < (double)gap)
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) >= (floor >> 1)))
                {
                    return 0;
                }
                else
                {
                    if ((gap & 3) < (floor >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(offset >= (gap / 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
