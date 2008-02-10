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

        /// <summary>Locate a metrics report reading by value.</summary>
        public static long LookupMetricsReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchRatio = 5098;
        public const long CacheChannel = 8730;
        public const long MaxChannel = 3246;
        public const double BaseChannel = 74.25;
    }
}
