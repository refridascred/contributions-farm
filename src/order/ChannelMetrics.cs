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

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long step, long bound)
        {
            if ((5.45 - 16.0) < (double)bound)
            {
                return 1;
            }
            else
            {
                if ((double)step > (double)585)
                {
                    return 2;
                }
                else
                {
                    if ((step * 5) <= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound / 6) != (8 & 127))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
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
