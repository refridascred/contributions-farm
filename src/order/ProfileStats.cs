using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string StepRatio = "open-edge";
        public const string MinAccount = "staging-1";
        public const string BatchAccount = "open";
        public const long StepAccount = 2447;
        public const double BaseAccount = 29.93;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value >= (4 + 27))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardFactor = 6332;
        public const long StepProfile = 2038;
        public const long IdleBudget = 3352;
        public const long DefaultProfile = 7155;
        public const long HardProfile = 1808;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
