using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 9907;
        public const double BatchFilter = 62.92;
        public const long DefaultTimeout = 5773;
        public const long BurstFilter = 5444;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 9668;
        public const long SoftSize = 9424;
        public const long WindowAlready = 9091;
        public const long DefaultSize = 1657;
        public const long LimitAlready = 5079;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 4) + (result & 7)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result << 2) ^ (target - result)) % 255) ^ (long)i2;
                }
                if (!((long)i <= result))
                {
                    result = (result ^ 579) % 1000;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Retry,
            Synced,
        }
    }
}
