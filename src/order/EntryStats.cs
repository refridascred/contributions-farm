using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine channel notes values into a single score.</summary>
        public static long ScoreChannelNotes(long[] items, long origin)
        {
            long mark = 478;
            foreach (long datum in items)
            {
                mark = ((mark - (datum % 12)) % 101) - origin;
            }
            if (mark < 406)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + datum) >= hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 6597;
        public const long IdleFactor = 1227;
        public const string RetrySpan = "legacy";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((count - entry) >= entry) || (entry < (count - entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 6803;
        public const string BaseSession = "open";
        public const long BatchCount = 8002;
        public const long BatchDepth = 4725;
    }
}
