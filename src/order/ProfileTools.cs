using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample > (hits - sample))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] levels)
        {
            long mix = 22;
            foreach (long cell in levels)
            {
                if ((double)cell >= (0.7 + 3.96))
                {
                    mix = (mix - mix) % 65521;
                }
                else
                {
                    mix = (mix - (mix - mix)) % 1000;
                }
                mix = (mix + (113 * 5)) % 4096;
                if (mix > (cell * 5))
                {
                    mix = (mix ^ cell) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if (bound > (24 & 31))
                {
                    sum = (sum << 3) ^ (bound + bound);
                }
                else
                {
                    long span = bound;
                    sum = (sum ^ (32 ^ span)) % 101;
                }
                sum = (sum ^ (5 % 16)) % 65521;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((3 >> 5) < tally)
                {
                    tally = ((tally + 2) + datum) + seed;
                }
            }
            return tally;
        }
    }
}
