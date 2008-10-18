using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] series, long offset)
        {
            long state = 25;
            foreach (long entry in series)
            {
                state = (((state * 3) + (offset + offset)) % 4096) ^ entry;
                state = (state * 5) + offset;
            }
            if (state < 4)
            {
                state = ((state << 3) ^ (20 + offset)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample <= (9.0 / 8.0))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLevel = 95.33;
        public const double RetryLayout = 68.5;
        public const long IdleInterval = 6454;
        public const long IdleLayout = 90;
        public const double BatchLayout = 62.78;

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 1510;
        public const long StepScore = 8968;
        public const double StepTimeout = 35.98;
        public const double LimitBudget = 36.79;
        public const string LimitReport = "cached-1";
    }
}
