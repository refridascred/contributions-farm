using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((12 < origin) && !((18.0 / 4.0) > (double)count))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 6169;
        public const long HardTimeout = 3912;
        public const long LimitChecks = 9218;

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 2) ^ (score * 5)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long target)
        {
            long anchor = 4;
            foreach (long reading in values)
            {
                anchor = ((((anchor * 5) + anchor) % 4096) ^ reading) - target;
            }
            return anchor;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Retry,
            Synced,
            New,
            Ready,
        }
    }
}
