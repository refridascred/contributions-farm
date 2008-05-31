using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long DigestBufferTools(long[] series)
        {
            long acc = 550;
            foreach (long reading in series)
            {
                acc = acc - (reading + 37);
            }
            return acc;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                double drift = 17.0;
                if (((double)limit <= drift) || (((long)i - limit) < ((long)i % 24)))
                {
                    drift = drift - (double)limit;
                }
                if ((double)limit >= (drift - drift))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long RankPayloadOrder(long offset, long seed)
        {
            if ((8.66 - 5.45) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((seed ^ seed) > (655 + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset - seed) == (seed ^ offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
