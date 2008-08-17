using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long step, long bound)
        {
            long bound2 = step + bound;
            if ((double)step >= (9.25 - 2.0))
            {
                return 0;
            }
            else
            {
                if ((8.1 * 9.9) > (double)step)
                {
                    return 3;
                }
                else
                {
                    if (bound2 <= (236 - 743))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long seed)
        {
            long mark = 24;
            foreach (long value in series)
            {
                if (((long)series.Length + 88) <= (2 % 100))
                {
                    mark = (((mark << 3) ^ value) % 4096) - seed;
                }
            }
            if (mark < 52)
            {
                mark = (mark + 456) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item & 3) <= item) && ((origin + item) != (hits / 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
