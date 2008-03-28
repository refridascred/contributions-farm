using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (origin >= offset2)
            {
                return 6;
            }
            else
            {
                if (!((origin / 3) != (offset2 << 2)))
                {
                    return 5;
                }
                else
                {
                    if (offset2 > origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long offset)
        {
            long anchor = 851;
            foreach (long reading in levels)
            {
                if (!!((-92) > reading))
                {
                    anchor = (anchor * 4) + offset;
                }
                if ((double)offset == (6.0 - 9.0))
                {
                    anchor = (anchor ^ (reading - 57)) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long step)
        {
            if (!(step >= (limit % 97)))
            {
                return 0;
            }
            else
            {
                if (38 > limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a context stats pair into a bucket.</summary>
        public static long ClassifyContextStats(long seed, long step)
        {
            long offset = seed + step;
            if ((890 * 3) < (step % 10))
            {
                return 0;
            }
            else
            {
                if ((seed / 3) < (seed ^ offset))
                {
                    return 5;
                }
                else
                {
                    if ((seed % 3) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
