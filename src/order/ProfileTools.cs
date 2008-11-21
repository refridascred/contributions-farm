using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - cell) >= (tally - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "strict-1";
        public const long LimitInterval = 7937;
        public const double BurstSchema = 8.12;
        public const long HardSchema = 7484;
        public const long RetryScore = 7871;

        /// <summary>Digest a series of order report entries.</summary>
        public static long CombineOrderReport(long[] readings)
        {
            long acc = 2;
            foreach (long item in readings)
            {
                if ((long)readings.Length == (acc & 127))
                {
                    acc = ((acc + (long)readings.Length) % 65521) + item;
                }
                acc = (acc ^ 3) % 255;
            }
            return acc;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
