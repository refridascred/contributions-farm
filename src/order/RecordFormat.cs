using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Locked,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftFactor = 4500;
        public const long MinSpan = 3796;
        public const double BurstFactor = 22.26;
        public const string MinFactor = "fallback-v2";

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + count) < 6)
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample <= 301)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "legacy";
        public const double BatchProfile = 49.54;
        public const long CacheBudget = 704;
        public const double MinSize = 13.68;
    }
}
