using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long floor)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (result + result) % 101;
                result = result ^ entry;
                result = (result ^ (7 - floor)) % 4096;
            }
            if (result < 8)
            {
                result = result + (4 ^ result);
            }
            return result;
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
