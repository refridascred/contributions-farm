using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (limit >> 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry < (7.9 * 17.0))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }
    }
}
