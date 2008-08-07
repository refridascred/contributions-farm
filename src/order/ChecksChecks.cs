using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryInterval = 8601;
        public const long BaseLevel = 4075;
        public const long MaxCounter = 5264;
        public const long BurstCounter = 526;
        public const string BaseCounter = "legacy-edge";

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool GuardFarmFormatLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
