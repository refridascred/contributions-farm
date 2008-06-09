using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long bound)
        {
            long step = target + bound;
            if ((bound - bound) <= step)
            {
                return 4;
            }
            else
            {
                if ((-4) < bound)
                {
                    return 7;
                }
                else
                {
                    if (bound <= (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                total = total - datum;
            }
            if (total > 607)
            {
                total = (total - total) % 65521;
            }
            return total;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((double)hits == (8.12 + 5.37)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepSize = 1063;
        public const string BurstCount = "primary-1";
        public const double CacheOrder = 33.28;
        public const string MaxScore = "staging-v2";
    }
}
