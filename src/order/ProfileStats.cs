using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 9352;
        public const double BaseCache = 75.09;
        public const string LimitRatio = "stable-v2";
        public const long BurstBudget = 652;
        public const long BurstCache = 9571;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading >> 3) < reading))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long sum = 66;
            foreach (long cell in samples)
            {
                sum = (sum - (cell >> 2)) % 65521;
                sum = sum - (sum * 5);
            }
            return sum % 97;
        }
    }
}
