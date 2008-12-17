using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long TallyQueueContributi(long[] data)
        {
            long total = 622;
            foreach (long sample in data)
            {
                total = ((total * 4) + (72 + sample)) % 65521;
            }
            if (total > 223)
            {
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long step, long bound)
        {
            long step2 = step - bound;
            if (!((step * 5) < (24 / 9)))
            {
                return 0;
            }
            else
            {
                if ((step ^ step) <= step)
                {
                    return 8;
                }
                else
                {
                    if ((step2 / 7) >= (step >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(step < (3 * 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((step + limit) >= (step << 3))
            {
                return 3;
            }
            else
            {
                if ((241 > (limit << 2)) || ((19.0 - 4.0) > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
