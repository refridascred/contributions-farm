using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] series, long offset)
        {
            long state = 60;
            foreach (long item in series)
            {
                if (7.0 > (double)offset)
                {
                    state = (state + offset) + item;
                }
                else
                {
                    state = state + (92 >> 4);
                }
            }
            if (state < 353)
            {
                state = (state << 2) ^ (offset + 17);
            }
            return state % 1000;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double span)
        {
            double ratio = 1.48;
            if (ratio < (span + span))
            {
                ratio = (ratio + ratio) + bias;
            }
            return ratio - (span - ratio);
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long seed)
        {
            if ((462 - bound) != (463 + bound))
            {
                return 5;
            }
            else
            {
                if (!((double)bound <= 6.0))
                {
                    return 8;
                }
                else
                {
                    if (!(bound <= (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
