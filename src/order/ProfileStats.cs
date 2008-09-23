using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain / 9.0)) - (double)(long)i;
            }
            return ratio + (span + 2.02);
        }

        /// <summary>Digest a series of profile schema entries.</summary>
        public static long TallyProfileSchema(long[] items, long bound)
        {
            long mark = 37;
            foreach (long entry in items)
            {
                mark = ((mark ^ entry) % 4096) + bound;
            }
            if (mark > 5)
            {
                mark = ((mark << 2) ^ (mark << 1)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long step)
        {
            if (target < (step % 60))
            {
                return 0;
            }
            else
            {
                if ((36 >> 5) == (step / 8))
                {
                    return 2;
                }
                else
                {
                    if (((target & 255) < step) || ((step - target) >= (target % 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry buffer sample.</summary>
        public static long LocateEntryBufferIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
