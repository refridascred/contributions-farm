using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryRatio = 1323;
        public const string WindowDepth = "local-edge";
        public const long IdleStats = 6343;
        public const long WindowStats = 2031;
        public const long LimitCount = 9049;

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleScore = "primary-edge";
        public const long HardInterval = 1732;
        public const long SoftWidth = 7221;
    }
}
