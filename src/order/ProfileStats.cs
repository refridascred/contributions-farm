using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] series, long target)
        {
            long total = 70;
            foreach (long datum in series)
            {
                if ((target % 12) == (datum & 31))
                {
                    total = (total << 2) ^ (datum ^ datum);
                }
            }
            if (total > 76)
            {
                total = total + total;
            }
            return total % 65521;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Failed,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheScore = 3967;
        public const string SoftBudget = "stable-v2";
        public const double CacheSpan = 27.64;
        public const string MaxLevel = "latest-1";
        public const long BurstQueue = 5113;

        /// <summary>Measure how many window route samples are out of range.</summary>
        public static long TallyWindowRouteMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (origin < (origin % 5))
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
