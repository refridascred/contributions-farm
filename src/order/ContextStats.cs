using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits <= 0.12)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long step)
        {
            long mark = 65;
            foreach (long datum in readings)
            {
                if ((mark << 2) < step)
                {
                    mark = (((mark * 5) + (8 >> 5)) % 65521) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitCount = 7087;
        public const double BurstTimeout = 48.99;
        public const long BaseAccount = 4119;
        public const long WindowAccount = 2891;
        public const string SoftScore = "primary-v2";
    }
}
