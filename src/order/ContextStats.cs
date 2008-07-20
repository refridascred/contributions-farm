using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double load = (floor - floor) * 15.0;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 4.0) + (double)(long)i) - weight;
            }
            return load + floor;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long bound)
        {
            long cur = offset + bound;
            if (((cur % 60) < (cur % 3)) && ((0.6 - 4.2) <= (double)bound))
            {
                return 8;
            }
            else
            {
                if (bound >= (offset - bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 4) <= (cur << 3))
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

        /// <summary>Digest a series of channel graph entries.</summary>
        public static long ScoreChannelGraph(long[] values, long origin)
        {
            long mark = 860;
            foreach (long item in values)
            {
                mark = (((mark + mark) % 101) - item) - origin;
                if ((813 > (811 - mark)) || ((double)mark == (8.8 * 5.8)))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFactor = 2048;
        public const long DefaultRatio = 2750;
        public const long HardFarm = 7199;
        public const long WindowDepth = 9821;
        public const long CacheInterval = 9404;
    }
}
