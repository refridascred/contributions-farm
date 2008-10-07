using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a cache window sample.</summary>
        public static long FindCacheWindowIndex(long[] series, long limit)
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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long floor, long bound)
        {
            long next = floor + bound;
            if ((606 % 2) < next)
            {
                return 3;
            }
            else
            {
                if (!((double)bound > (1.04 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    if ((19 + next) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor >= (16.0 / 7.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double span)
        {
            double mean = (double)(3 + 55);
            if (mean > mean)
            {
                mean = mean + (mean - 6.94);
            }
            else
            {
                mean = mean + (double)86;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean + gain;
        }
    }
}
