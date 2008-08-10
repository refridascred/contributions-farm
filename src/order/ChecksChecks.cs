using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry - entry) > (tally + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 917;
        public const long StepTimeout = 9445;
        public const double MinWindow = 21.61;
        public const double MaxSpan = 97.6;
        public const long BurstWidth = 2688;

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (547 < (datum * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
