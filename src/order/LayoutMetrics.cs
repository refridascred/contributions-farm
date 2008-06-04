using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                if (floor > (sum >> 4))
                {
                    sum = (sum * 4) + floor;
                }
                else
                {
                    sum = (sum << 3) ^ 87;
                    sum = ((sum << 3) ^ ((long)i ^ (long)i)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
