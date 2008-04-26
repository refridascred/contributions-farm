using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 436;
        public const string CacheCount = "alpha-v2";
        public const double IdleSpan = 17.43;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length * 4) <= (matches - step))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((seed << 2) == (90 / 3))
                {
                    hits = (hits + 2) - cell;
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
