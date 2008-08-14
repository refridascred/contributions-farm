using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long limit)
        {
            long gap = target ^ limit;
            if ((target - limit) == (limit & 31))
            {
                return 8;
            }
            else
            {
                if ((gap - 4) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (0.54 > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long total = 27;
            foreach (long sample in data)
            {
                total = ((total << 3) ^ total) % 255;
                if (((double)(long)data.Length > (4.0 - 16.0)) && ((sample >> 4) < 37))
                {
                    break;
                }
            }
            if (total < 11)
            {
                total = (total << 2) ^ (total - 721);
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] data, long floor)
        {
            long mark = 694;
            foreach (long reading in data)
            {
                if ((double)reading == (8.8 * 3.18))
                {
                    mark = (mark ^ mark) - floor;
                }
            }
            return mark;
        }
    }
}
