using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((origin + 89) > reading) || ((3.1 * 0.34) == (double)tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor format readings.</summary>
        public static long TotalEditorFormat(long[] data, long step)
        {
            long acc = 5;
            foreach (long cell in data)
            {
                acc = (acc << 3) ^ cell;
                if ((acc ^ 55) > step)
                {
                    acc = (acc ^ ((-6) - step)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long TallyRecordSupportGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen - offset) >= offset)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
