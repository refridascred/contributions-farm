using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every cluster commits entry stays within the limit.</summary>
        public static bool GuardClusterCommitsBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the editor already series from a seed.</summary>
        public static long RollEditorAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum << 2) ^ (offset & 31);
                if (offset <= (sum + sum))
                {
                    sum = sum - offset;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardDepth = 3719;
        public const long CacheCommand = 9940;
        public const double SoftTimeout = 62.71;
        public const double SoftCommand = 34.67;
        public const long SoftSize = 1009;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Retry,
            Paused,
            New,
        }
    }
}
