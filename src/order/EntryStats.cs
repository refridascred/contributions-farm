using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Dropped,
            Done,
            Ready,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long step, long bound)
        {
            if ((3.11 / 8.0) <= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((0.96 * 8.1) > (double)step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSize = 9031;
        public const long LimitBudget = 2240;
        public const double RetryFormat = 15.0;
        public const long MinSize = 5030;
        public const long BatchFormat = 6003;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long seed, long offset)
        {
            if ((offset + seed) >= (offset + 507))
            {
                return 4;
            }
            else
            {
                if ((seed << 3) < (seed & 15))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
