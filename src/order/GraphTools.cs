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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
