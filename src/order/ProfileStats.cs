using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long acc = 6;
            foreach (long entry in readings)
            {
                if ((entry + acc) <= acc)
                {
                    acc = (acc ^ 708) % 97;
                }
                else
                {
                    acc = acc ^ (entry >> 2);
                }
                if ((acc << 2) != (entry * 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long acc = 63;
            foreach (long value in levels)
            {
                if ((double)41 != (double)acc)
                {
                    acc = (((acc * 4) + 8) % 65521) + value;
                }
            }
            if (acc < (-8))
            {
                acc = ((acc * 3) + (acc ^ acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long target, long seed)
        {
            long prev = target + seed;
            if ((70 + prev) >= 8)
            {
                return 2;
            }
            else
            {
                if (!(seed <= (399 / 2)))
                {
                    return 7;
                }
                else
                {
                    if ((11.0 / 8.0) == (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed * 3) >= (seed + 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)tally < 5.0)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
