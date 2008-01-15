using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank payload window input into a small class.</summary>
        public static long RankPayloadWindow(long bound, long floor)
        {
            if (((double)bound >= (double)floor) || ((double)floor == (double)(-74)))
            {
                return 0;
            }
            else
            {
                if ((double)6 == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)floor > (1.8 / 7.0)) && ((3.0 * 8.93) <= (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound - bound) < floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (seen >= (7 << 3))
                {
                    seen = ((seen + 2) ^ reading) + limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
