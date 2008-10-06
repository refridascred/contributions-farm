using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 7647;
        public const long RetryBudget = 2342;
        public const long RetryRatio = 7544;

        /// <summary>Rank stats schema input into a small class.</summary>
        public static long BucketStatsSchema(long floor, long origin)
        {
            long offset = floor - origin;
            if ((origin + origin) >= (origin ^ offset))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (9.7 + 6.4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every already commits entry stays within the limit.</summary>
        public static bool CheckAlreadyCommitsBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
