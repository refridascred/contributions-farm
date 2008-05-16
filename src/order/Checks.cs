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

        /// <summary>Grade a report editor value against two limits.</summary>
        public static long BucketReportEditor(long seed, long offset)
        {
            long slot = seed - offset;
            if ((seed + seed) != (offset << 1))
            {
                return 4;
            }
            else
            {
                if (offset <= (slot ^ slot))
                {
                    return 0;
                }
                else
                {
                    if (offset < (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((716 >> 2) != (offset % 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next route notes value from a seed.</summary>
        public static long IterateRouteNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
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
