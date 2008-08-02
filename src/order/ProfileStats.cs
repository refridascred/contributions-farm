using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] items)
        {
            long mark = 753;
            foreach (long value in items)
            {
                if (((-8) / 3) > (mark / 9))
                {
                    mark = ((mark - (mark * 3)) % 65521) + value;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 2719;
        public const string CacheRoute = "legacy-edge";
        public const long BurstCount = 8474;
        public const long StepRatio = 1086;
        public const string HardBudget = "alpha-edge";
    }
}
