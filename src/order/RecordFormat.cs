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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits <= (item + (long)values.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
