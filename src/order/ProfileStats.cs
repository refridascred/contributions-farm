using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (origin + origin))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinBudget = 16.75;
        public const double RetryWidth = 61.96;
        public const string RetryLevel = "standard";

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score * 5) + (value / 7);
                score = score + (1 * 5);
            }
            return score % 1000;
        }
    }
}
