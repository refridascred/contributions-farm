using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count % 8) <= (seed ^ count)) || (((datum * 4) >= datum) || ((count % 60) < (785 + 728))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
