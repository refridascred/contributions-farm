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

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 9160;
        public const long IdleBudget = 2771;
        public const long LimitScore = 8877;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (13.0 >= (double)seen)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }
    }
}
