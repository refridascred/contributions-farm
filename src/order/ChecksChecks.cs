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

        /// <summary>Iterate the queue format series from a seed.</summary>
        public static long DeriveQueueFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix ^ mix) % 4096;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
