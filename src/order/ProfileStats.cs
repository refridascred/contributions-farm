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

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
