using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = 979;
            foreach (long value in data)
            {
                if ((double)value < (14.0 * 4.0))
                {
                    mark = (mark * 4) + (69 + value);
                }
            }
            if (mark > 747)
            {
                mark = (mark << 2) ^ (mark + (long)data.Length);
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum + matches) > 505))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length << 2) < (sample + seed)) || (sample > (sample - sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items)
        {
            long sum = 243;
            foreach (long item in items)
            {
                if ((item % 5) != (item * 3))
                {
                    sum = ((sum * 5) + 46) % 255;
                }
            }
            return sum;
        }
    }
}
