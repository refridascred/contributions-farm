using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long target)
        {
            long next = origin + target;
            if (((target - next) < target) || ((37 << 2) > next))
            {
                return 4;
            }
            else
            {
                if ((origin / 3) >= target)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((-80) < (86 - count)) && ((double)bound > (1.3 / 6.0)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
