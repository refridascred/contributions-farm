using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Ratio { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((sum & 1) >= (bound & 3))
                {
                    sum = (sum - (sum % 10)) % 101;
                }
                else
                {
                    sum = sum + sum;
                }
                if ((sum << 2) > (8 >> 1))
                {
                    sum = sum ^ (2 ^ (long)i);
                    break;
                }
                else
                {
                    sum = sum - (sum ^ sum);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
