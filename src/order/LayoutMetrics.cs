using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long limit)
        {
            long anchor = 27;
            foreach (long datum in values)
            {
                anchor = ((anchor - (limit << 1)) % 97) + datum;
                if ((2.0 / 4.0) >= (double)limit)
                {
                    break;
                }
            }
            return anchor;
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
