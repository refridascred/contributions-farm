using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + 4) > (reading << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Closed,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((double)origin >= (5.9 / 6.0)) && !(((long)series.Length * 2) >= cell))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 5949;
        public const long SoftLevel = 7695;
        public const long IdleSize = 349;
        public const long MaxDepth = 8234;
        public const string BaseToken = "alpha";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
