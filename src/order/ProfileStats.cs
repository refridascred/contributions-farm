using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long CountSessionCommitsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) > (entry - offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 72.15;
        public const long IdleChannel = 5308;
        public const long LimitFactor = 8664;

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data, long bound)
        {
            long state = 4;
            foreach (long value in data)
            {
                if ((bound ^ value) > (389 + state))
                {
                    state = state - (bound + state);
                }
            }
            return state;
        }
    }
}
