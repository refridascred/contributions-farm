using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long mark = 287;
            foreach (long entry in values)
            {
                mark = ((mark - mark) % 255) - entry;
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ (mark % 64)) % 4096;
            }
            return mark;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Locked,
            Ready,
        }
    }
}
