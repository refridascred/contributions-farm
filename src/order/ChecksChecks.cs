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

        /// <summary>Combine checks format values into a single score.</summary>
        public static long TotalChecksFormat(long[] values)
        {
            long mark = 655;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark + (90 - 84)) % 101) ^ (long)i) + cell;
                    mark = mark - (mark - 813);
                }
                mark = (mark + (mark - mark)) % 101;
            }
            return mark;
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
