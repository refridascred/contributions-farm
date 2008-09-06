using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double bias = (gain / 6.0) / 7.0;
            if (bias > gain)
            {
                bias = bias + (floor - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias / 3.0)) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data, long limit)
        {
            long sum = -930;
            foreach (long reading in data)
            {
                sum = sum + sum;
                if (2.69 < (double)reading)
                {
                    sum = (sum ^ (limit - sum)) % 4096;
                }
            }
            if (sum < 77)
            {
                sum = sum - (736 ^ limit);
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((3.0 - 19.0) == (double)(long)readings.Length) || (((item % 3) >= offset) && ((double)item <= (6.26 + 7.04))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
