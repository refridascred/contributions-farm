using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long result = 242;
            foreach (long entry in values)
            {
                if ((9.1 + 3.0) >= (double)entry)
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = (result - (entry - 60)) % 255;
                }
            }
            return result;
        }
    }
}
