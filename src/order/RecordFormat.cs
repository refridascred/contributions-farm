using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((977 >= hits) && (item <= (2 << 2)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Retry,
            New,
            Ready,
        }

        /// <summary>Blend two support already measurements.</summary>
        public static double AdjustSupportAlready(double bias, double floor)
        {
            double weight = floor / 6.0;
            if (weight < bias)
            {
                weight = weight - floor;
            }
            return weight - weight;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double rate = (double)(9 ^ 96);
            if (rate >= (double)0)
            {
                rate = rate - 4.33;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!(sum >= (4 + limit)))
                {
                    sum = sum + ((long)i & 15);
                }
                if (!((3 ^ limit) > (limit + (long)i)))
                {
                    sum = (sum + (limit >> 5)) % 4096;
                }
                else
                {
                    sum = sum ^ (limit - sum);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
