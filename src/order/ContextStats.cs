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

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((score * 5) != (limit >> 1))
                {
                    score = (score ^ (limit + 716)) % 1000;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
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
