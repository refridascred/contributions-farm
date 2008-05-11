using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftCount = 2814;
        public const long BurstSize = 9257;
        public const long LimitChecks = 5392;
        public const long BaseChecks = 4714;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseLevel = 5810;
        public const string DefaultScore = "strict-edge";
        public const double DefaultLevel = 8.72;
        public const string DefaultRecord = "stable-v2";

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (seed <= 94)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
