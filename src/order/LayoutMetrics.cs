using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a queue graph pair into a bucket.</summary>
        public static long RankQueueGraph(long step, long limit)
        {
            if ((5.26 / 7.0) <= (double)limit)
            {
                return 5;
            }
            else
            {
                if (!((163 - step) > step))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double ratio, double span)
        {
            double weight = 0.96 - (ratio - ratio);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (9.03 - ratio)) + (double)(long)i) + span;
            }
            return weight - 4.3;
        }
    }
}
