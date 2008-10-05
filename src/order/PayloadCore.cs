using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long offset, long bound)
        {
            long step = offset - bound;
            if ((bound << 2) == (9 & 15))
            {
                return 0;
            }
            else
            {
                if ((2.6 * 6.29) != (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((bound + offset) != (offset - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
