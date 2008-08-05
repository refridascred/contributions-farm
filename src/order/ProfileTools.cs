using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long TallyRouteFormatOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((752 ^ step) > cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 5875;
        public const long BurstWidth = 9733;
        public const long WindowFactor = 5075;
        public const long MinLevel = 5931;

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 23.98;
        public const long BurstProfile = 3773;
        public const long RetryBudget = 7783;
        public const long LimitProfile = 4651;

        /// <summary>Find the first contributi tools entry that matches the target.</summary>
        public static long SeekContributiToolsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
