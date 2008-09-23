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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long floor)
        {
            if ((5 + floor) < (floor / 5))
            {
                return 3;
            }
            else
            {
                if ((seed * 3) <= floor)
                {
                    return 8;
                }
                else
                {
                    if ((seed & 3) <= 7)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
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
