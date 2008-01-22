using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepLevel = 25.62;
        public const long DefaultWidth = 9665;
        public const long IdleRecord = 7799;
        public const long RetryRecord = 1930;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the queue tools series from a seed.</summary>
        public static long DeriveQueueTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i < sum)
                {
                    sum = (sum ^ (sum - 43)) % 1000;
                }
                sum = sum ^ sum;
                sum = (sum + (long)i) % 4096;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
