using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 1870;
        public const double BaseInterval = 23.7;
        public const long IdleBudget = 4558;
        public const long RetrySize = 1883;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxWidth = 39.79;
        public const long BatchGithubfarm = 2761;
        public const long DefaultRatio = 4863;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum >= floor) || ((2.3 / 7.0) >= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
