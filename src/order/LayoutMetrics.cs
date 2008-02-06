using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next profile metric value.</summary>
        public static double BlendProfileMetric(double weight, double floor)
        {
            double mean = weight;
            if (mean > (double)(-398))
            {
                mean = mean + (weight * 9.2);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean - (floor / 5.0);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
