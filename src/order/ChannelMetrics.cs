using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats profile pair into a bucket.</summary>
        public static long ClassifyStatsProfile(long limit, long bound)
        {
            long offset = limit ^ bound;
            if ((double)offset <= (8.5 * 12.0))
            {
                return 3;
            }
            else
            {
                if (limit > (limit - limit))
                {
                    return 5;
                }
                else
                {
                    if (((-63) * 5) <= (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((655 * 4) <= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a token entry reading.</summary>
        public static double ScaleTokenEntry(double scale, double floor)
        {
            double mean = floor * 11.0;
            if (mean >= floor)
            {
                mean = (mean + (double)430) + scale;
            }
            else
            {
                mean = mean - (7.64 + mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (mean / 7.0)) + (double)(long)i;
            }
            return mean - (2.0 + mean);
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
