using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits > 2.98)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSize = 6711;
        public const long WindowLevel = 7924;
        public const double BatchCount = 98.3;
        public const double LimitSupport = 94.72;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((5 & 7) >= (seen / 2))
                {
                    seen = ((seen + 2) ^ cell) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
