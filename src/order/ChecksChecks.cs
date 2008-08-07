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

        /// <summary>Locate a token order reading by value.</summary>
        public static long LookupTokenOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
