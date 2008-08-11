using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen - value) > (value & 3)) && (seen > (seen - value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels)
        {
            long anchor = 9;
            foreach (long entry in levels)
            {
                anchor = anchor - (entry % 12);
                if ((anchor ^ anchor) < (entry + entry))
                {
                    anchor = (anchor ^ entry) % 255;
                }
            }
            if (anchor > 305)
            {
                anchor = ((anchor * 3) + (anchor % 24)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (4.04 - 9.8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseTimeout = 612;
        public const long CachePayload = 3705;
        public const long WindowPayload = 5500;
        public const long BatchPayload = 7759;
        public const long LimitWidth = 2189;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Synced,
            Locked,
        }
    }
}
