using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the counter cache series from a seed.</summary>
        public static long StepCounterCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)carry >= (9.2 * 3.0)))
                {
                    carry = ((carry * 5) + (limit + (long)i)) % 101;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double LimitStream = 77.28;
        public const long CacheTimeout = 269;
        public const string MinDepth = "strict-edge";

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches % 3) >= (value & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
