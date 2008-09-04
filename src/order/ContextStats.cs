using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(target < (-1)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if (((double)limit >= (double)1) && ((origin >> 3) > 898))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) < (70 << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double ratio, double span)
        {
            double mean = span;
            if (mean < (18.0 - 2.0))
            {
                mean = (mean - mean) + ratio;
            }
            else
            {
                mean = mean - (span / 7.0);
            }
            return mean - span;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinLevel = 62.55;
        public const long RetryToken = 7218;
        public const long BatchCount = 7667;
    }
}
