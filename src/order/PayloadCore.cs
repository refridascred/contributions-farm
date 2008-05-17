using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!(sample >= (matches + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((611 * 2) <= (605 + cell))
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 94.5;
        public const string WindowSpan = "staging-1";
        public const long LimitDepth = 6076;
        public const double BurstQueue = 93.43;
        public const long BatchQueue = 5783;
    }
}
