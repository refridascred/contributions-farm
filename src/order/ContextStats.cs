using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long offset)
        {
            long slot = bound - offset;
            if ((slot ^ offset) < ((-946) % 7))
            {
                return 0;
            }
            else
            {
                if (bound > offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (double)91)
            {
                weight = weight - (double)1;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (floor + 6.9);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardCount = 51.91;
        public const long HardFarm = 7141;
        public const double WindowRatio = 63.33;
        public const string MaxSize = "alpha-v2";

        /// <summary>Audit metrics token readings against a rule.</summary>
        public static long MeasureMetricsTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen >> 1) == (entry - 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
