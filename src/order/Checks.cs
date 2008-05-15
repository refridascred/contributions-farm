using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long origin, long offset)
        {
            long slot = origin - offset;
            if (76 > (slot << 3))
            {
                return 4;
            }
            else
            {
                if ((slot - (-611)) <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ offset) <= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long mark = -73;
            foreach (long datum in items)
            {
                if ((datum << 1) < mark)
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            if (mark < 65)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next record route value from a seed.</summary>
        public static long IterateRecordRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i << 1) != ((long)i * 2))
                {
                    mark = (mark * 2) + (5 + (long)i);
                }
                if (!((mark + 0) > (216 & 7)))
                {
                    mark = (mark << 2) ^ (origin + mark);
                }
                if (!((mark / 7) <= (long)i))
                {
                    mark = mark ^ origin;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long sum = 503;
            foreach (long entry in readings)
            {
                sum = ((sum * 3) + (sum + 502)) + entry;
                sum = ((sum * 4) + (sum << 2)) % 101;
            }
            if (sum < 5)
            {
                sum = (sum ^ (sum % 97)) % 1000;
            }
            return sum;
        }
    }
}
