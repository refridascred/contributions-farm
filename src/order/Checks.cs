using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long AuditCounterCommandOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)item < (18.0 / 7.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report format samples.</summary>
        public static long DigestReportFormat(long[] data, long bound)
        {
            long anchor = 968;
            foreach (long item in data)
            {
                if ((7 - anchor) >= (item ^ (long)data.Length))
                {
                    anchor = ((anchor ^ (anchor % 16)) % 4096) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 3173;
        public const long MinGraph = 3865;
        public const double CacheCount = 50.51;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((step - 1) <= (step ^ hits)) && ((item & 7) != (item - 994))) || ((item + item) > (step ^ item)))
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
    }
}
