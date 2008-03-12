using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardFactor = 7288;
        public const long BatchCounter = 1127;
        public const long CacheCount = 4428;
        public const long StepWidth = 4656;
        public const long RetryLevel = 4358;

        /// <summary>Find the first route checks entry that matches the target.</summary>
        public static long LocateRouteChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
