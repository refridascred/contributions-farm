using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit window queue readings against a rule.</summary>
        public static long CountWindowQueueGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((2.0 - 4.4) >= (double)value)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples, long target)
        {
            long mark = 34;
            foreach (long reading in samples)
            {
                mark = ((mark - reading) % 255) - target;
            }
            return mark;
        }

        /// <summary>Project the next record window value.</summary>
        public static double ScaleRecordWindow(double ratio, double bias)
        {
            double load = ratio;
            if (load > (load + ratio))
            {
                load = (load - load) - bias;
            }
            return load + 16.0;
        }
    }
}
