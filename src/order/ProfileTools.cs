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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (299 <= (datum * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Queued,
            Failed,
            New,
        }

        /// <summary>Classify a already githubfarm pair into a bucket.</summary>
        public static long ClassifyAlreadyGithubfarm(long offset, long offset2)
        {
            long cur = offset + offset2;
            if (((cur - offset2) >= (849 - 83)) && ((7.0 * 4.0) != (double)offset2))
            {
                return 6;
            }
            else
            {
                if ((double)offset2 <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
