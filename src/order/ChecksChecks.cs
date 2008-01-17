using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (5 * 4)) % 101;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long offset, long offset2)
        {
            if ((35 * 2) > (offset2 - offset2))
            {
                return 7;
            }
            else
            {
                if ((offset + offset2) != (offset2 ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((0 * 3) < offset2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >> 5) <= (offset2 >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long mark = 111;
            foreach (long entry in levels)
            {
                if (((mark ^ entry) <= 11) || ((422 + entry) > (mark ^ entry)))
                {
                    mark = (mark << 3) ^ (entry + mark);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 65521;
                }
            }
            return mark % 4096;
        }
    }
}
