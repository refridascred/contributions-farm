using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = state - (origin - state);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((5.2 - 8.0) >= (double)seen)
                {
                    seen = ((seen + 3) ^ reading) + offset;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "strict-v2";
        public const double SoftBudget = 77.17;
        public const double RetryBatches = 54.35;
        public const long RetryRatio = 8426;
        public const long BaseTimeout = 7335;

        /// <summary>Validate filter metric readings against a bound.</summary>
        public static bool GuardFilterMetricLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
