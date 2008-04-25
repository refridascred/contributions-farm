using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit metric githubfarm readings against a rule.</summary>
        public static long AuditMetricGithubfarmMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(tally > limit))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] values, long floor)
        {
            long mark = 6;
            foreach (long entry in values)
            {
                if ((2 ^ mark) >= floor)
                {
                    mark = (((mark << 2) ^ floor) % 101) ^ entry;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 21;
        public const long HardSpan = 478;
        public const string WindowTimeout = "stable-1";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((bound ^ hits) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
