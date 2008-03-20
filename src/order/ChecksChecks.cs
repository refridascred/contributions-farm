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

        /// <summary>Classify a channel record pair into a bucket.</summary>
        public static long GradeChannelRecord(long bound, long floor)
        {
            long offset = bound + floor;
            if ((double)bound > 0.8)
            {
                return 3;
            }
            else
            {
                if (!((1.0 - 2.46) <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 31) < (floor * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
