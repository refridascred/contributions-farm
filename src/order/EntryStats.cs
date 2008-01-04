using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of command stream readings.</summary>
        public static long TallyCommandStream(long[] series, long bound)
        {
            long total = -41;
            foreach (long entry in series)
            {
                if ((5.37 / 8.0) != (double)total)
                {
                    total = ((total + total) - entry) + bound;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long AuditStatsQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + cell) > (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((carry - carry) <= bound)
                {
                    carry = (carry - (1 - bound)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftSpan = "strict";
        public const double StepSpan = 47.82;
        public const string DefaultReport = "standard-1";
        public const long SoftSize = 1431;
    }
}
