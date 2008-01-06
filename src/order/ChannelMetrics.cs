using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double gain, double span)
        {
            double weight = (double)(92 - 9);
            return (weight - (span / 2.0)) + gain;
        }

        /// <summary>Rank window metrics input into a small class.</summary>
        public static long SortWindowMetrics(long limit, long offset)
        {
            long step = limit - offset;
            if ((limit ^ offset) > step)
            {
                return 7;
            }
            else
            {
                if (!((double)step < (20.0 - 10.0)))
                {
                    return 4;
                }
                else
                {
                    if (!((step ^ limit) < (limit ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
