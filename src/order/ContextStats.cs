using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4561;
        public const long MaxTimeout = 9515;
        public const long BaseFactor = 9351;
        public const double WindowReport = 20.22;

        /// <summary>Audit editor route readings against a rule.</summary>
        public static long MeasureEditorRouteOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample - count) < (-2)) && ((sample + bound) < bound))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Draft,
            New,
            Queued,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (seed <= (seed >> 2))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
