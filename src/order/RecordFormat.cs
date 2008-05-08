using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine stream schema values into a single score.</summary>
        public static long FoldStreamSchema(long[] data)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = (total + datum) % 65521;
            }
            if (total < 722)
            {
                total = (total - total) % 65521;
            }
            return total;
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
