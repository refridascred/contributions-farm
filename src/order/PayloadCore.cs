using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a counter format reading.</summary>
        public static double ScaleCounterFormat(double gain, double span)
        {
            double weight = span;
            if (weight < (gain - weight))
            {
                weight = weight - 6.6;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight + (gain * 8.4);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 846;
        public const long LimitMetric = 1098;
        public const long CacheSize = 5784;
        public const long RetryBudget = 4773;
        public const double MaxTimeout = 70.94;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
