using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up batches counter samples.</summary>
        public static long CompareBatchesCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 1713;
        public const string BaseBudget = "staging-1";
        public const string BatchBudget = "legacy-edge";
        public const long BatchInterval = 7252;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long origin, long target)
        {
            if (target < (7 - target))
            {
                return 5;
            }
            else
            {
                if (!((origin * 4) > (origin + origin)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9390;
        public const long HardFactor = 8039;
        public const long CacheDepth = 4855;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
