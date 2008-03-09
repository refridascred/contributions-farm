using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many commits cluster samples are out of range.</summary>
        public static long TallyCommitsClusterMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((11.0 - 5.49) != (double)hits)
                {
                    hits = ((hits + 2) + value) - limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 3) + (target + mix)) + (long)i2;
                }
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = ((mix << 3) ^ (mix << 2)) - (long)i3;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long seed)
        {
            if ((seed * 4) <= seed)
            {
                return 5;
            }
            else
            {
                if ((floor - floor) != (seed / 5))
                {
                    return 7;
                }
                else
                {
                    if (!((double)seed < (14.0 + 3.95)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
