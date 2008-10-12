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

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 6816;
        public const double LimitChecks = 20.8;
        public const long HardCount = 7117;
        public const long StepChecks = 1254;
        public const long BaseChecks = 4632;

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
