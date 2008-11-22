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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Pending,
            Paused,
            New,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + hits) != (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
