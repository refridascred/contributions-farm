using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double weight, double floor)
        {
            double rate = (floor / 2.0) / 7.0;
            if (rate >= (floor / 3.0))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (weight * 7.8)) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (17 >= reading)
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a channel payload value against two limits.</summary>
        public static long SortChannelPayload(long bound, long floor)
        {
            if ((14.0 - 6.55) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((3.7 + 4.2) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
