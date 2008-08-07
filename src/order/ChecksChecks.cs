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

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels)
        {
            long score = 7;
            foreach (long datum in levels)
            {
                if ((score + score) != (datum + 1))
                {
                    score = ((score << 3) ^ (score << 3)) % 4096;
                }
            }
            return score;
        }
    }
}
