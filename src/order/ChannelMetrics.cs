using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double floor)
        {
            double weight = (double)86 / 2.0;
            if (weight > (weight - floor))
            {
                weight = (weight - (double)90) - bias;
            }
            else
            {
                weight = weight - 1.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (double)(-392)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 1240;
        public const string RetryNotes = "open";
        public const long SoftSpan = 1850;

        /// <summary>Grade a token metric value against two limits.</summary>
        public static long ClassifyTokenMetric(long floor, long offset)
        {
            if (!((double)offset <= 1.5))
            {
                return 7;
            }
            else
            {
                if ((floor / 3) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
