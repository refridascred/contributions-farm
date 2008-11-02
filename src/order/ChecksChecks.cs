using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long step, long seed)
        {
            if ((4.3 + 3.0) < (double)step)
            {
                return 1;
            }
            else
            {
                if (!((double)step > (4.1 + 12.0)))
                {
                    return 8;
                }
                else
                {
                    if ((step / 6) == (seed / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series)
        {
            long mark = 858;
            foreach (long sample in series)
            {
                mark = (mark - (sample % 5)) % 1000;
                if ((sample + sample) > 330)
                {
                    mark = (mark ^ mark) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long limit, long floor)
        {
            long offset = limit - floor;
            if (offset >= (floor + limit))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= 8.2)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
