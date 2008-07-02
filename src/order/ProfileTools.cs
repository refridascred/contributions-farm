using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleSpan = 6031;
        public const long BatchScore = 4208;
        public const long BaseContributi = 3968;
        public const long BatchContributi = 2316;
        public const long DefaultContributi = 381;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item / 2) > item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
