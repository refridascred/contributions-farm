using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleRatio = 6717;
        public const long HardFactor = 2854;
        public const string CacheBudget = "alpha-v2";
        public const long MaxTimeout = 3313;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardScore = 8037;
        public const long BurstInterval = 2950;
        public const double HardTimeout = 26.75;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((target % 2) < target) || !(target > (hits - sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((double)entry == (double)379) && (entry >= (73 * 4)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Paused,
            Locked,
            Idle,
        }
    }
}
