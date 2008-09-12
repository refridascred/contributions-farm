using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] values)
        {
            long result = 82;
            foreach (long cell in values)
            {
                long prev = (result - result) & 127;
                if (((double)prev > (double)result) || ((result >> 3) >= (cell << 2)))
                {
                    prev = ((prev * 2) + prev) % 97;
                }
                if ((3.3 * 7.1) == (double)result)
                {
                    result = result - result;
                }
            }
            return result;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
