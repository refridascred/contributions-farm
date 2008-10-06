using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 5186;
        public const double DefaultRoute = 61.17;
        public const double StepRoute = 3.53;
        public const long BurstRatio = 7478;
        public const long HardRoute = 2246;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "alpha";
        public const long DefaultBudget = 7293;
        public const long BaseInterval = 9437;
        public const string CacheBatches = "alpha-edge";

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((entry - 78) < offset))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double ratio, double bias)
        {
            double mean = bias;
            if (mean > mean)
            {
                mean = (mean - (bias / 4.0)) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + 14.0;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
