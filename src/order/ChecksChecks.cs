using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (3.5 - 4.19))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
