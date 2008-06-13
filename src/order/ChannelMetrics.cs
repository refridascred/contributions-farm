using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long floor)
        {
            long next = target + floor;
            if (floor > (6 + next))
            {
                return 7;
            }
            else
            {
                if ((0.3 / 5.0) < (double)next)
                {
                    return 1;
                }
                else
                {
                    if (((next / 8) > next) && ((floor >> 5) < (target ^ 98)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double gain = (bias + 0.89) * 4.2;
            if (gain <= (9.04 + offset))
            {
                gain = gain + (bias - bias);
            }
            return gain - (double)93;
        }

        /// <summary>Project the next stats stream value.</summary>
        public static double ScaleStatsStream(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= 1.4)
            {
                bias = bias + ratio;
            }
            return bias + (bias / 7.0);
        }
    }
}
