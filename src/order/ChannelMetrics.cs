using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a already context reading by value.</summary>
        public static long LocateAlreadyContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double ratio, double floor)
        {
            double mean = ratio * 7.5;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + 5.6;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long step, long seed)
        {
            if (((27 + 6) > step) || ((double)seed <= 10.0))
            {
                return 4;
            }
            else
            {
                if ((seed / 6) <= seed)
                {
                    return 6;
                }
                else
                {
                    if (5.96 < (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
