using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (matches % 7))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((7.3 / 7.0) <= (double)hits)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally <= reading)
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 5098;
        public const long CacheChannel = 8730;
        public const long MaxChannel = 3246;
        public const double BaseChannel = 74.25;
    }
}
