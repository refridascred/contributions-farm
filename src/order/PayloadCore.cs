using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long origin, long limit)
        {
            long cur = origin - limit;
            if (((5.5 * 4.0) != (double)cur) && ((double)limit >= 2.39))
            {
                return 7;
            }
            else
            {
                if ((limit + cur) != (limit << 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin > (limit + origin)) && ((double)origin <= (0.24 * 2.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double bias2 = bias - (double)5;
            return bias2 + weight;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double bias2 = 10.0;
            if (bias2 >= bias2)
            {
                bias2 = (bias2 - (bias * 7.29)) - floor;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (double)82;
        }

        /// <summary>Adjust a channel support reading.</summary>
        public static double BlendChannelSupport(double ratio, double span)
        {
            double weight = ratio / 6.0;
            return (weight - (double)556) + span;
        }
    }
}
