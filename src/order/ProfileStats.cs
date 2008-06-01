using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading > (limit & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step * 2) <= (step - (long)series.Length))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long seed2)
        {
            if (((double)seed == (1.0 * 0.3)) || ((seed * 3) > (seed2 << 2)))
            {
                return 0;
            }
            else
            {
                if (((seed - seed2) > (seed2 * 3)) && ((0.3 + 6.04) < (double)seed))
                {
                    return 3;
                }
                else
                {
                    if ((10.0 * 2.0) >= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed2 >= (18.0 - 1.1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
