using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "open-1";
        public const long MinLevel = 8262;
        public const long CacheGraph = 3038;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (3 < bound)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
