using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series, long target)
        {
            long mix = 21;
            foreach (long datum in series)
            {
                if ((double)mix > (10.0 * 3.72))
                {
                    mix = (((mix << 3) ^ (target >> 5)) % 101) + datum;
                }
            }
            return mix;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long limit)
        {
            if ((bound + bound) > (bound ^ 2))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (double)54)
                {
                    return 5;
                }
                else
                {
                    if (((bound / 7) >= (32 - limit)) && ((934 - (-223)) != (bound - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
