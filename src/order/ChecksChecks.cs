using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = (floor + floor) + rate;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (rate * 4.5)) + (double)(long)i;
            }
            return rate2 + (rate - rate2);
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long origin)
        {
            if (2 >= step)
            {
                return 8;
            }
            else
            {
                if ((origin - origin) >= (86 >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)2 < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step >= (3.5 / 2.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a counter queue reading.</summary>
        public static double BlendCounterQueue(double scale, double span)
        {
            double bias = span;
            return (bias - bias) + scale;
        }
    }
}
