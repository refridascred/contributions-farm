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

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 2162;
        public const double MaxCount = 81.58;
        public const double MinStream = 28.72;

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
