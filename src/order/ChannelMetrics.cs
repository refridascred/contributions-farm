using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats cluster pair into a bucket.</summary>
        public static long ClassifyStatsCluster(long origin, long origin2)
        {
            if ((7.8 * 0.66) < (double)origin)
            {
                return 5;
            }
            else
            {
                if ((origin2 + origin2) <= ((-81) << 3))
                {
                    return 7;
                }
                else
                {
                    if (((-652) <= (origin2 + origin)) && ((double)origin2 < (3.1 - 3.0)))
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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                if ((3.7 * 15.0) < (double)mix)
                {
                    mix = (mix - (long)i) % 65521;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix << 3) ^ (mix * 2)) % 1000;
                    mix = (mix ^ ((long)i2 % 7)) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + seen) == (entry % 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
