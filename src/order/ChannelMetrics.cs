using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long offset2)
        {
            if ((double)offset2 == (2.0 + 6.0))
            {
                return 5;
            }
            else
            {
                if (((double)offset == (16.0 + 2.4)) && ((offset + offset2) >= (offset * 2)))
                {
                    return 7;
                }
                else
                {
                    if ((122 ^ offset2) < (offset2 + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((19 - offset) < offset) || ((8.22 * 3.5) >= (double)53))
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
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((-1) <= ((long)levels.Length & 1)) && (hits <= (reading - hits))))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
