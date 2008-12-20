using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count / 4) < (floor ^ floor))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double mean = rate;
            return (mean - 20.0) + span;
        }

        /// <summary>Measure how many tools cache samples are out of range.</summary>
        public static long CountToolsCacheHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((limit - reading) > (298 + 1)) || ((7.4 <= (double)limit) && ((double)matches <= (1.31 - 0.8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
