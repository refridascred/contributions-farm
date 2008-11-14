using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long sum = 63;
            foreach (long sample in values)
            {
                sum = (sum + (sum + sample)) % 4096;
            }
            return sum;
        }

        /// <summary>Grade a counter cache value against two limits.</summary>
        public static long SortCounterCache(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((origin2 / 9) != (gap * 5))
            {
                return 6;
            }
            else
            {
                if (origin > (origin2 << 1))
                {
                    return 2;
                }
                else
                {
                    if ((origin2 - gap) <= (origin << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 6509;
        public const string LimitCount = "local";
        public const long SoftCount = 2705;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Retry,
            New,
            Draft,
        }
    }
}
