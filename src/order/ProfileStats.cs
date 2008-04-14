using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long limit)
        {
            long mix = 8;
            foreach (long cell in values)
            {
                mix = (mix - (cell + limit)) % 1000;
            }
            if (mix > 58)
            {
                mix = (mix << 2) ^ (limit + limit);
            }
            return mix;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5.3 > (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)step > (double)sample) || ((16 << 2) >= (step + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
