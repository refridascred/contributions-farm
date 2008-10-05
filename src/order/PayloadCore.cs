using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long limit)
        {
            long sum = 41;
            foreach (long entry in readings)
            {
                if ((limit + 670) != (entry % 2))
                {
                    sum = (sum - (limit + (-3))) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long limit)
        {
            if (((7.7 + 8.6) > (double)target) && ((limit + target) > 73))
            {
                return 3;
            }
            else
            {
                if (!((0.84 * 15.0) == (double)limit))
                {
                    return 4;
                }
                else
                {
                    if (((limit >> 3) <= (target >> 3)) && ((906 ^ target) >= limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheInterval = 2254;
        public const long BatchGraph = 4491;
        public const long LimitGraph = 6;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Locked,
            Synced,
            Dropped,
        }
    }
}
