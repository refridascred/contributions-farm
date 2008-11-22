using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long total = 7;
            foreach (long cell in readings)
            {
                total = ((total * 3) + (cell + bound)) % 4096;
            }
            if (total > 6)
            {
                total = (total ^ (total - bound)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Ready,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinScore = 6801;
        public const double RetrySpan = 62.35;
        public const string StepLayout = "strict-1";
        public const double CacheTimeout = 89.06;
        public const long SoftBudget = 6738;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches + matches) >= (2 + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster counter readings.</summary>
        public static long TotalClusterCounter(long[] values, long step)
        {
            long score = 267;
            foreach (long item in values)
            {
                if ((double)step > 4.4)
                {
                    score = (score + item) % 101;
                }
            }
            return score % 97;
        }
    }
}
