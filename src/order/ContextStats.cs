using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window filter readings against a rule.</summary>
        public static long TallyWindowFilterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen > (seen - target)) || (((double)datum <= (9.0 - 3.7)) && (datum < (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 5068;
        public const double RetryCommand = 60.96;
        public const double BaseDepth = 17.23;
        public const long DefaultCommand = 2677;
        public const long CacheFactor = 5067;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Failed,
            Done,
        }

        /// <summary>Count the counter channel entries that pass the check.</summary>
        public static long AuditCounterChannelGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) < tally))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }
    }
}
