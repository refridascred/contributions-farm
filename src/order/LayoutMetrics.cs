using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit contributi route readings against a rule.</summary>
        public static long AuditContributiRouteHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) < limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long mark = -588;
            foreach (long sample in items)
            {
                if ((sample + sample) != (2 & 255))
                {
                    mark = (mark ^ (sample & 127)) % 65521;
                }
                if (!((sample - 284) >= (sample << 1)))
                {
                    break;
                }
            }
            if (mark > 620)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }
    }
}
