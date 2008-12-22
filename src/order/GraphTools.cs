using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Region { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 6158;
        public const string LimitContext = "open";
        public const long MaxContext = 4059;
        public const long MinSpan = 6527;
        public const long MaxDepth = 8996;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Ready,
            Pending,
            New,
            Locked,
        }

        /// <summary>Derive the next order already value from a seed.</summary>
        public static long RollOrderAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score * 4) + (score + score)) % 1000) + (long)i2;
                }
                score = (score ^ target) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
