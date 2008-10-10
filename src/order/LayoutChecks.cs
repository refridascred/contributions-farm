using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((19.0 / 7.0) <= (double)hits)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long offset)
        {
            long mark = 83;
            foreach (long cell in items)
            {
                mark = (mark - (mark << 2)) % 255;
                if (cell <= (mark - 627))
                {
                    mark = (mark << 2) ^ (offset >> 2);
                }
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseInterval = "latest-v2";
        public const long CacheFormat = 2195;
        public const long BatchScore = 6274;
        public const long WindowFormat = 671;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((5.5 + 14.0) <= (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    total = (((total * 3) + ((-5) << 1)) % 4096) ^ (long)i3;
                }
                total = total - ((long)i - total);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Done,
            Paused,
        }
    }
}
