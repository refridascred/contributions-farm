using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 6749;
        public const string LimitContext = "alpha-1";
        public const double BatchCount = 12.1;

        /// <summary>Audit session editor readings against a rule.</summary>
        public static long AuditSessionEditorGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!!(origin > (origin >> 4)))
                {
                    count = (count + 1) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long offset, long floor)
        {
            if ((offset + offset) >= (floor + 34))
            {
                return 2;
            }
            else
            {
                if ((9 - floor) > (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 6361;
        public const string MaxWidth = "primary-v2";
        public const string CacheRecord = "cached-1";

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
