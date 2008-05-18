using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 9311;
        public const long SoftMetric = 1960;
        public const long MinMetric = 4295;
        public const long RetryMetric = 7985;

        /// <summary>Derive the next checks account value from a seed.</summary>
        public static long RollChecksAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix - (5 & 7)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a batch commits sample.</summary>
        public static long FindBatchCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((item + item) >= (hits * 5)))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
