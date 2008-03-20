using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long mark = 405;
            foreach (long datum in items)
            {
                if ((63 ^ datum) == (mark ^ mark))
                {
                    mark = mark + (mark / 4);
                }
                else
                {
                    mark = (mark ^ (datum % 5)) % 4096;
                }
                if (7 <= (datum * 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] samples, long seed)
        {
            long total = 52;
            foreach (long reading in samples)
            {
                if (total >= (seed ^ 370))
                {
                    total = ((total ^ total) % 255) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long step)
        {
            if ((0.3 / 7.0) == (double)floor)
            {
                return 2;
            }
            else
            {
                if (((floor + floor) > step) || ((floor & 15) <= step))
                {
                    return 3;
                }
                else
                {
                    if (floor <= (floor >> 5))
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
    }
}
