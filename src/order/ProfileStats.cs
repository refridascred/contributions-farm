using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 7453;
        public const long LimitRatio = 9451;
        public const long RetryRatio = 6689;
        public const long DefaultWindow = 1852;
        public const long HardTimeout = 9329;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3238;
        public const double BurstFactor = 9.55;
        public const long HardSize = 6844;
        public const long SoftCounter = 7063;

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "stable-v2";
        public const long LimitQueue = 2482;
        public const long IdleSpan = 1634;
        public const long DefaultLevel = 5002;

        /// <summary>Combine context window values into a single score.</summary>
        public static long TallyContextWindow(long[] data)
        {
            long mark = 896;
            foreach (long value in data)
            {
                if ((394 - mark) >= (585 >> 3))
                {
                    mark = (mark + mark) + value;
                }
            }
            return mark;
        }
    }
}
