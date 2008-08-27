using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Done,
            Idle,
        }
    }
}
