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

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "strict-edge";
        public const long SoftSize = 4261;
        public const long BurstFactor = 4377;
        public const long BaseWindow = 8597;
        public const double HardWindow = 48.48;

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
