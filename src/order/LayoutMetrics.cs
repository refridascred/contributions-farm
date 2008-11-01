using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((count << 1) <= item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (!((1 / 6) == (value - origin)) && (2.0 <= (double)origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
