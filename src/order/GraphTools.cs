using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Locked,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Dropped,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Roll a checks record counter forward.</summary>
        public static long IterateChecksRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = acc + (target + acc);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate stats schema readings against a bound.</summary>
        public static bool GuardStatsSchemaLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRatio = 7201;
        public const long DefaultScore = 3664;
        public const long RetryFactor = 5551;
        public const double CacheRatio = 43.51;
    }
}
