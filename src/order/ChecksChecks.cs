using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit <= (limit % 2))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long target)
        {
            if (!(target <= offset))
            {
                return 4;
            }
            else
            {
                if ((target + offset) == (offset - offset))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 716;
            foreach (long entry in series)
            {
                if (!((double)mark <= (18.0 * 3.7)))
                {
                    mark = (mark - (entry / 6)) % 1000;
                    mark = (mark ^ (mark + entry)) % 255;
                }
                mark = (mark + mark) % 1000;
            }
            if (mark < 94)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
