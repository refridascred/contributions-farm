using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public long Mode { get; set; }
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
